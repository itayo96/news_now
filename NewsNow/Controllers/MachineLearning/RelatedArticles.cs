using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Learners;
using System;

namespace ML
{
    class MachineLearning
    {
        // STEP 1: Define your data structures
        // IrisData is used to provide training data, and as
        // input for prediction operations
        // - First 4 properties are inputs/features used to predict the label
        // - Label is what you are predicting, and is only set when training
        public class RelatedArticleData
        {
            [Column("0")]
            public float CurrentArticleId;

            [Column("1")]
            [ColumnName("Label")]
            public float Label;
        }

        // IrisPrediction is the result returned from prediction operations
        public class RelatedArticlesPrediction
        {
            [ColumnName("PredictedLabel")]
            public float PredictedRelatedArticle;
        }

        public static int GetRelatedArticle(string dataPath, int ArticleId)
        {
            // STEP 2: Create an environment  and load your data
            var env = new LocalEnvironment();            

            var reader = new TextLoader(env,
                new TextLoader.Arguments()
                {
                    Separator = ",",
                    HasHeader = true,
                    Column = new[]
                    {
                            new TextLoader.Column("CurrentArticleId", DataKind.R4, 0),
                            new TextLoader.Column("Label", DataKind.R4, 1)
                    }
                });

            IDataView trainingDataView = reader.Read(new MultiFileSource(dataPath));

            // STEP 3: Transform your data and add a learner
            // Assign numeric values to text in the "Label" column, because only
            // numbers can be processed during model training.
            // Add a learning algorithm to the pipeline. e.g.(What type of iris is this?)
            // Convert the Label back into original text (after converting to number in step 3)
            var pipeline = new TermEstimator(env, "Label", "Label")
                   .Append(new ConcatEstimator(env, "Features", "CurrentArticleId"))
                   .Append(new SdcaMultiClassTrainer(env, new SdcaMultiClassTrainer.Arguments()))
                   .Append(new KeyToValueEstimator(env, "PredictedLabel"));

            // STEP 4: Train your model based on the data set  
            var model = pipeline.Fit(trainingDataView);

            // STEP 5: Use your model to make a prediction
            // You can change these numbers to test different predictions
            var prediction = model.MakePredictionFunction<RelatedArticleData, RelatedArticlesPrediction>(env).Predict(
                new RelatedArticleData()
                {
                    CurrentArticleId = (float)ArticleId
                });

            return (int)prediction.PredictedRelatedArticle;
        }
    }
}
