using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class MoreData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 7, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 2, new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Content", "DateCreated", "Header", "HomeImageUrl", "Summery" },
                values: new object[,]
                {
                    { 4, 1, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Israel rejects russian claims: IAF did not hide behind russian plane", "https://www.jpost.com/HttpHandlers/ShowImage.ashx?id=350908&w=898&h=628", "The IAF did not hide behind any plane and Israeli fighter jets were in Israeli airspace when the Syrians attacked the Russian plane" },
                    { 5, 1, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "U.S. Terror victomsm ask Trump: bar Abbas", "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/428957", "The family members called the decision to allow Abbas’s entry to the US \"a slap in the face to every American who has suffered from terror.\"" },
                    { 6, 5, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Trails and Tribulations of Eurovision 2019, What to expect next?", "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429094", "For the next eight months, squabbles over politics, money and religion are bound to plague the upcoming Eurovision. But which arguments should be taken seriously?" },
                    { 7, 5, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Livinng out the Baha'i: A journy to israel", "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429990", "More than a million people visit the gardens every year. Apart from being at the holiest site of his faith..." },
                    { 8, 5, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Highlights: Texas snaps 4-game skid to No. 17 TCU", "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345", "Finland has produced more Formula One champions per capita than any other country in the world" },
                    { 9, 6, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Russia is still attacking the US and trying to help Trump", "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345", "Microsoft's revelation of yet another Russian operation assaulting democratic institutions -- including conservative think tanks that disagree with President Trump -- proves that Vladimir Putin is still trying to help Trump, writes Frida Ghitis." },
                    { 10, 3, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "Comcast outbids 21st Century Fox for Sky", "https://i.cdn.turner.com/money/dam/assets/180920115724-comcast-fox-sky-780x439.jpg", "American cable giant Comcast lodged a winning bid of about $40 billion (£30.6 billion) for Sky following a rare, three round auction managed by UK's Takeover Panel" },
                    { 11, 3, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


                example paragraph
                --

                The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

                *""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

                paragraph with image
                --
                *""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

                The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
                Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
                All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

                ![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
                *Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

                *""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
                Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
                ", new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "BMW vision's for a self-driving electric car", "https://i.cdn.turner.com/money/dam/assets/180913172656-bmw-inext-780x439.jpg", "BMW has unveiled its vision for a self-driving electric crossover SUV and, if it actually ends up being a lot like the concept." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 36, 20, 944, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2018, 9, 24, 0, 36, 20, 949, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 36, 20, 949, DateTimeKind.Local));
        }
    }
}
