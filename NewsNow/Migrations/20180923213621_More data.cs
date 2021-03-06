﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Moredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Content", "DateCreated" },
                values: new object[] { 1, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


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
", new DateTime(2018, 9, 24, 0, 36, 20, 944, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Content", "DateCreated", "Header", "HomeImageUrl", "Summery" },
                values: new object[] { 2, 1, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


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
", new DateTime(2018, 9, 24, 0, 36, 20, 949, DateTimeKind.Local), "Gilad Erdan: Israel making progess against Terror", "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_TopStoryMainImageFaceDetect/429944", "Erdan is responsible for the fight against BDS in the Strategic Affairs Ministry, and the steps he has taken in that battle are controversial and unconventional." });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Content", "DateCreated", "Header", "HomeImageUrl", "Summery" },
                values: new object[] { 3, 1, @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


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
", new DateTime(2018, 9, 24, 0, 36, 20, 949, DateTimeKind.Local), "Rusia: We were mislead by israel", "https://www.jpost.com/HttpHandlers/ShowImage.ashx?id=350908&w=898&h=628", "Maj. Gen. Igor Konashenkov, chief spokesman for the Russian Ministry of Defense, said that Israeli strikes in Syria put Russian forces there at risk." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Content", "DateCreated" },
                values: new object[] { 2, "The assailants behind Saturday's attack at an Iranian military parade will face \"deadly and unforgettable\" revenge in the near future, Iranian state media reported Sunday.It cited a statement from Iran's Islamic Revolutionary Guards Corps that said no effort would be spared in the hunt for those responsible for the terror attack.The Revolutionary Guards accused Saudi Arabia of supporting perpetrators of the attack that killed 29 people and wounded 70 others. The casualties included both military personnel and civilians, the state-run Islamic Republic News Agency reported.29 killed in attack on Iranian military parade29 killed in attack on Iranian military paradeOn Sunday, President Hassan Rouhani blamed \"foreign mercenaries\" backed by the United States.\"It is America who supports these little mercenary countries in the region. It is Americans who are provoking them. It is Americans who provide them with their required necessities to perpetrate such crimes,\" Rouhani said on his official website.\"The government is ready to counter any action by the US, and the Americans will regret this,\" Rouhani said. It was not immediately clear if this remark referred to the Ahvaz attack or the US withdrawal from the 2015 Iran nuclear deal.\"Most importantly, today Americans are bullying the world more than ever and continuing their unilateralist policies,\" he said of the nuclear deal.The United States will not accomplish \"their goals in Iran,\" he added.Rouhani made the comments ahead of a trip this week to New York, where he will attend the UN General Assembly.US dismisses accusations as 'rhetoric'But Nikki Haley, the US ambassador to the United Nations, rejected Iran's accusations.\"You've got a lot of rhetoric coming from Rouhani. The United States condemns any terrorist attack anywhere, period. We've always stood by that. I think what Rouhani needs to do is he needs to look at his own home base,\" Haley told CNN's \"State of the Union\" on Sunday.Rouhani warns US that &#39;war with Iran is the mother of all wars&#39;Rouhani warns US that 'war with Iran is the mother of all wars'\"He can blame us all he wants; the thing he's got to do is look in the mirror.\"Despite increased tensions with Iran, Haley emphasized that the United States was not seeking regime change anywhere.\"The United States is not looking to do regime change in Iran. We're not looking to do regime change anywhere. What we are looking to do is protect Americans, protect our allies ... ,\" she said.\"The President has been very strong on Iran. ... Iran's economy has plummeted because the President pulled out of the (nuclear) deal. They're getting desperate. And I think we're seeing the actions of that.\"US State Department spokeswoman Heather Nauert called the attack \"terrorism.\"\"We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,\" she said Saturday.The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.Injured soldiers lie on the ground after Saturday&#39;s attack on a military parade Ahvaz, Iran.Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.\"The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,\" said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.Iranian Foreign Minister Mohammad Javad Zarif also blamed \"a foreign regime\" backed by the United States for Saturday's attack.\"Terrorists recruited, trained, armed & paid by a foreign regime have attacked Ahvaz,\" Zarif said in a tweet, adding: \"Iran holds regional terror sponsors and their US masters accountable for such attacks.\"Revolutionary Guards spokesman Ramezan Sharif said the attackers were affiliated with a terrorist group supported by Saudi Arabia, Iran's state-run Press TV said.\"The individuals who fired at the people and the armed forces during the parade are connected to the al-Ahvaziya group, which is fed by Saudi Arabia,\" Sharif said. Saudi Arabia hasn't responded to the allegations.Earlier, Rouhani used the occasion of the military parades to compare President Donald Trump to former Iraqi dictator Saddam Hussein, Press TV reported.Speaking at a military rally in Tehran, he said Trump will fail in the \"economic and psychological war\" he's launched against Iran, just as Hussein failed in his war against the Islamic Republic.\"Iran will neither abandon its defensive weapons nor will reduce its defense capabilities,\" Rouhani said.\"Rather it will increase its defense power day by day. The fact that they are angry at our missiles shows that these are the most influential weapons Iran has.\"Allies and regional governments offer supportRegional governments condemned the attack and offered their condolences, including Hamas, Qatar and a number of Saudi Arabia's reginal allies such as Kuwait, Oman and Egypt. Saudi Arabia was missing from the list of customary diplomatic condolences.A soldier wounded in the attack is treated Saturday at the scene in Ahvaz.A soldier wounded in the attack is treated Saturday at the scene in Ahvaz.Syrian President Bashar al-Assad and Hezbollah, two of Iran's closest allies, issued statements condemning the attack, with Assad referring to outside involvement and Hezbollah echoing allegations of US blame.\"We are with you with all the power we have\" to stand against these terrorist acts, Assad said in a cable to Rouhani, the state-run Syrian Arab News Agency reported. \"We hope that the backers, financers and proponents of terrorism will understand that this danger threatens mankind as a whole.\"Hezbollah in a statement said \"satanic and malignant hands are behind this terrorist action,\" and accused the United States and its allies of conducting it \"directly or by proxy.\" The attack is intended to undermine Iran's security and stability and as \"punishment for ... its rejection of American dependency politics,\" the statement said.Iran's Foreign Ministry summoned the ambassadors of the Netherlands and Denmark, along with a senior British diplomat, on Saturday to issue a strong protest, Iran's state-run media reported.Who attacked Iran&#39;s military parade?Who attacked Iran's military parade?Bahram Ghasemi, a Foreign Ministry spokesman, said Iran \"re-emphasized\" to the diplomats a previous warning about the presence in their countries of a group that Iran classifies as terrorist and wants its members arrested and prosecuted.According to IRNA, Ghasemi said it is unacceptable that members of a terrorist group be allowed in those countries and not be included on the European Union's terror list only because they have not committed crimes on European soil.There was confusion Sunday as for who carried out the attack, with several groups named in local media but only ISIS claiming responsibility -- without any evidence to support its assertion.The separatist Patriotic Arab Democratic Movement in Ahwaz issued an emphatic denial after IRNA reported it had claimed responsibility.\"On behalf of #PADMAZ organization we reject all accusations and we insist that PADMAZ organization is a civil political movement and has nothing to do with what (happened) today in #IranMilitaryParade attack,\" the group, using its acronym, said on unconfirmed Twitter and Facebook accounts.Another group, the Arab Struggle Movement for the Liberation of Al-Ahwaz, was also accused of perpetrating the attack. But a spokesman, Yacoub Hor Al-Tustari, told CNN his group was not to blame.CNN's Sara Mazloumsaki, Jonny Hallam, Ghazi Balkiz, Siomara Germain, Kareem Khadder, Nada Altaher and Lauren Said-Moorhouse contributed to this report.", new DateTime(2018, 9, 24, 0, 21, 38, 172, DateTimeKind.Local) });
        }
    }
}
