using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace rpolCS
{
    public partial class Form1 : Form
    {
        string workingFolder;
        string workingFilename = @"rpolCS.txt";
        string plainTextFile = @"rpolPlainText.txt";
        string workingPath;
        string charName, discName, circleNum, raceName, genderName, ageNum, hairName, skinName, eyesName, heightNum,
               weightNum, pobName, resName, passionName, lSpokenName, lWrittenName, dexNum, dexLPinc, dexCurNum,
               dexStepNum, dexActDieNum, strNum, strLPinc, strCurNum, strStepNum, strActDieNum, initStepNum, initActDie,
               touNum, touLPinc, touCurNum, touStepNum, touActDieNum, perNum, perLPinc, perCurNum, perStepNum,
               perActDieNum, phyDefNum, wilNum, wilLPinc, wilCurNum, wilStepNum, wilActDieNum, mysDefNum,
               chaNum, chaLPinc, chaCurNum, chaStepNum, chaActDieNum, socDefNum, movNum, carryNum, karmaCurNum,
               karmaMaxNum, armorName, recovTestNum, recovStepNum, recovActDieNum, shieldName, deflectBonusNum, phyArmNum, 
               uncBaseNum, uncAdjNum, uncCurNum, dmgCurNum, deathBaseNum, deathAdjNum, deathCurNum, 
               woundCurNum, woundThreshNum, woundPenNum, numOfTalents_s, talentName01, talentName02, talentName03, talentName04,
               talentName05, talentName06, talentName07, talentName08, talentName09, talentName10, talentName11, talentName12;
        string talentName13, talentName14, talentName15, 
               actionType01, strainYN01, attName01, rankNum01, talStepNum01, talADnum01,
               actionType02, strainYN02, attName02, rankNum02, talStepNum02, talADnum02,
               actionType03, strainYN03, attName03, rankNum03, talStepNum03, talADnum03,
               actionType04, strainYN04, attName04, rankNum04, talStepNum04, talADnum04,
               actionType05, strainYN05, attName05, rankNum05, talStepNum05, talADnum05,
               actionType06, strainYN06, attName06, rankNum06, talStepNum06, talADnum06,
               actionType07, strainYN07, attName07, rankNum07, talStepNum07, talADnum07,
               actionType08, strainYN08, attName08, rankNum08, talStepNum08, talADnum08,
               actionType09, strainYN09, attName09, rankNum09, talStepNum09, talADnum09,
               actionType10, strainYN10, attName10, rankNum10, talStepNum10, talADnum10,
               actionType11, strainYN11, attName11, rankNum11, talStepNum11, talADnum11,
               actionType12, strainYN12, attName12, rankNum12, talStepNum12, talADnum12,
               actionType13, strainYN13, attName13, rankNum13, talStepNum13, talADnum13,
               actionType14, strainYN14, attName14, rankNum14, talStepNum14, talADnum14,
               actionType15, strainYN15, attName15, rankNum15, talStepNum15, talADnum15;
        string charAppearanceText, charPersonalityText, legendPointsNumText;
        string[] charHistoryText, miscNotesText, legendPointsText;
        int numOfTalents_i, paragraphNumNum, i_charHistoryText, miscNotesNum, legendPointsNum;


        public Form1()
        {
            InitializeComponent();
        }

        private void savePlainText()
        {
            FileStream ptfs = new FileStream(@workingFolder + @"\" + plainTextFile, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ptwriter = new StreamWriter(ptfs);
            #region // BasicInfo
            ptwriter.WriteLine("<BasicInfo>");
            ptwriter.WriteLine(charName);
            ptwriter.WriteLine(discName);
            ptwriter.WriteLine(circleNum);
            ptwriter.WriteLine(raceName);
            ptwriter.WriteLine(genderName);
            ptwriter.WriteLine(ageNum);
            ptwriter.WriteLine(hairName);
            ptwriter.WriteLine(skinName);
            ptwriter.WriteLine(eyesName);
            ptwriter.WriteLine(heightNum);
            ptwriter.WriteLine(weightNum);
            ptwriter.WriteLine(pobName);
            ptwriter.WriteLine(resName);
            ptwriter.WriteLine(passionName);
            ptwriter.WriteLine(lSpokenName);
            ptwriter.WriteLine(lWrittenName);
            ptwriter.WriteLine(dexNum);
            ptwriter.WriteLine(dexLPinc);
            ptwriter.WriteLine(dexCurNum);
            ptwriter.WriteLine(dexStepNum);
            ptwriter.WriteLine(dexActDieNum);
            ptwriter.WriteLine(strNum);
            ptwriter.WriteLine(strLPinc);
            ptwriter.WriteLine(strCurNum);
            ptwriter.WriteLine(strStepNum);
            ptwriter.WriteLine(strActDieNum);
            ptwriter.WriteLine(initStepNum);
            ptwriter.WriteLine(initActDie);
            ptwriter.WriteLine(touNum);
            ptwriter.WriteLine(touLPinc);
            ptwriter.WriteLine(touCurNum);
            ptwriter.WriteLine(touStepNum);
            ptwriter.WriteLine(touActDieNum);
            ptwriter.WriteLine(perNum);
            ptwriter.WriteLine(perLPinc);
            ptwriter.WriteLine(perCurNum);
            ptwriter.WriteLine(perStepNum);
            ptwriter.WriteLine(perActDieNum);
            ptwriter.WriteLine(wilNum);
            ptwriter.WriteLine(wilLPinc);
            ptwriter.WriteLine(wilCurNum);
            ptwriter.WriteLine(wilStepNum);
            ptwriter.WriteLine(wilActDieNum);
            ptwriter.WriteLine(chaNum);
            ptwriter.WriteLine(chaLPinc);
            ptwriter.WriteLine(chaCurNum);
            ptwriter.WriteLine(chaStepNum);
            ptwriter.WriteLine(chaActDieNum);
            ptwriter.WriteLine(phyDefNum);
            ptwriter.WriteLine(mysDefNum);
            ptwriter.WriteLine(socDefNum);
            ptwriter.WriteLine(movNum);
            ptwriter.WriteLine(carryNum);
            ptwriter.WriteLine(karmaCurNum);
            ptwriter.WriteLine(karmaMaxNum);
            ptwriter.WriteLine(recovTestNum);
            ptwriter.WriteLine(recovStepNum);
            ptwriter.WriteLine(recovActDieNum);
            ptwriter.WriteLine(armorName);
            ptwriter.WriteLine(shieldName);
            ptwriter.WriteLine(deflectBonusNum);
            ptwriter.WriteLine(phyArmNum);
            ptwriter.WriteLine(mysDefNum);
            ptwriter.WriteLine(uncBaseNum);
            ptwriter.WriteLine(uncAdjNum);
            ptwriter.WriteLine(uncCurNum);
            ptwriter.WriteLine(dmgCurNum);
            ptwriter.WriteLine(deathBaseNum);
            ptwriter.WriteLine(deathAdjNum);
            ptwriter.WriteLine(deathCurNum);
            ptwriter.WriteLine(woundCurNum);
            ptwriter.WriteLine(woundThreshNum);
            ptwriter.WriteLine(woundPenNum);
            #endregion
            #region // Talent Tab
            ptwriter.WriteLine("<Talents>");
            ptwriter.WriteLine(numOfTalents_i);
            if (numOfTalents_i >= 1)
            {
                ptwriter.WriteLine(talentName01);
                ptwriter.WriteLine(actionType01);
                ptwriter.WriteLine(strainYN01);
                ptwriter.WriteLine(attName01);
                ptwriter.WriteLine(rankNum01);
                ptwriter.WriteLine(talStepNum01);
                ptwriter.WriteLine(talADnum01);
            }
            if (numOfTalents_i >= 2)
            {
                ptwriter.WriteLine(talentName02);
                ptwriter.WriteLine(actionType02);
                ptwriter.WriteLine(strainYN02);
                ptwriter.WriteLine(attName02);
                ptwriter.WriteLine(rankNum02);
                ptwriter.WriteLine(talStepNum02);
                ptwriter.WriteLine(talADnum02);
            }
            if (numOfTalents_i >= 3)
            {
                ptwriter.WriteLine(talentName03);
                ptwriter.WriteLine(actionType03);
                ptwriter.WriteLine(strainYN03);
                ptwriter.WriteLine(attName03);
                ptwriter.WriteLine(rankNum03);
                ptwriter.WriteLine(talStepNum03);
                ptwriter.WriteLine(talADnum03);
            }
            if (numOfTalents_i >= 4)
            {
                ptwriter.WriteLine(talentName04);
                ptwriter.WriteLine(actionType04);
                ptwriter.WriteLine(strainYN04);
                ptwriter.WriteLine(attName04);
                ptwriter.WriteLine(rankNum04);
                ptwriter.WriteLine(talStepNum04);
                ptwriter.WriteLine(talADnum04);
            }
            if (numOfTalents_i >= 5)
            {
                ptwriter.WriteLine(talentName05);
                ptwriter.WriteLine(actionType05);
                ptwriter.WriteLine(strainYN05);
                ptwriter.WriteLine(attName05);
                ptwriter.WriteLine(rankNum05);
                ptwriter.WriteLine(talStepNum05);
                ptwriter.WriteLine(talADnum05);
            }
            if (numOfTalents_i >= 6)
            {
                ptwriter.WriteLine(talentName06);
                ptwriter.WriteLine(actionType06);
                ptwriter.WriteLine(strainYN06);
                ptwriter.WriteLine(attName06);
                ptwriter.WriteLine(rankNum06);
                ptwriter.WriteLine(talStepNum06);
                ptwriter.WriteLine(talADnum06);
            }
            if (numOfTalents_i >= 7)
            {
                ptwriter.WriteLine(talentName07);
                ptwriter.WriteLine(actionType07);
                ptwriter.WriteLine(strainYN07);
                ptwriter.WriteLine(attName07);
                ptwriter.WriteLine(rankNum07);
                ptwriter.WriteLine(talStepNum07);
                ptwriter.WriteLine(talADnum07);
            }
            if (numOfTalents_i >= 8)
            {
                ptwriter.WriteLine(talentName08);
                ptwriter.WriteLine(actionType08);
                ptwriter.WriteLine(strainYN08);
                ptwriter.WriteLine(attName08);
                ptwriter.WriteLine(rankNum08);
                ptwriter.WriteLine(talStepNum08);
                ptwriter.WriteLine(talADnum08);
            }
            if (numOfTalents_i >= 9)
            {
                ptwriter.WriteLine(talentName09);
                ptwriter.WriteLine(actionType09);
                ptwriter.WriteLine(strainYN09);
                ptwriter.WriteLine(attName09);
                ptwriter.WriteLine(rankNum09);
                ptwriter.WriteLine(talStepNum09);
                ptwriter.WriteLine(talADnum09);
            }
            if (numOfTalents_i >= 10)
            {
                ptwriter.WriteLine(talentName10);
                ptwriter.WriteLine(actionType10);
                ptwriter.WriteLine(strainYN10);
                ptwriter.WriteLine(attName10);
                ptwriter.WriteLine(rankNum10);
                ptwriter.WriteLine(talStepNum10);
                ptwriter.WriteLine(talADnum10);
            }
            if (numOfTalents_i >= 11)
            {
                ptwriter.WriteLine(talentName11);
                ptwriter.WriteLine(actionType11);
                ptwriter.WriteLine(strainYN11);
                ptwriter.WriteLine(attName11);
                ptwriter.WriteLine(rankNum11);
                ptwriter.WriteLine(talStepNum11);
                ptwriter.WriteLine(talADnum11);
            }
            if (numOfTalents_i >= 12)
            {
                ptwriter.WriteLine(talentName12);
                ptwriter.WriteLine(actionType12);
                ptwriter.WriteLine(strainYN12);
                ptwriter.WriteLine(attName12);
                ptwriter.WriteLine(rankNum12);
                ptwriter.WriteLine(talStepNum12);
                ptwriter.WriteLine(talADnum12);
            }
            if (numOfTalents_i >= 13)
            {
                ptwriter.WriteLine(talentName13);
                ptwriter.WriteLine(actionType13);
                ptwriter.WriteLine(strainYN13);
                ptwriter.WriteLine(attName13);
                ptwriter.WriteLine(rankNum13);
                ptwriter.WriteLine(talStepNum13);
                ptwriter.WriteLine(talADnum13);
            }
            if (numOfTalents_i >= 14)
            {
                ptwriter.WriteLine(talentName14);
                ptwriter.WriteLine(actionType14);
                ptwriter.WriteLine(strainYN14);
                ptwriter.WriteLine(attName14);
                ptwriter.WriteLine(rankNum14);
                ptwriter.WriteLine(talStepNum14);
                ptwriter.WriteLine(talADnum14);
            }
            if (numOfTalents_i >= 15)
            {
                ptwriter.WriteLine(talentName15);
                ptwriter.WriteLine(actionType15);
                ptwriter.WriteLine(strainYN15);
                ptwriter.WriteLine(attName15);
                ptwriter.WriteLine(rankNum15);
                ptwriter.WriteLine(talStepNum15);
                ptwriter.WriteLine(talADnum15);
            }
            #endregion
            #region // Misc Notes Tab
            ptwriter.WriteLine("<MiscNotes>");
            ptwriter.WriteLine(miscNotesNum);
            for (int i = 0; i < miscNotesNum; i++)
            {
                ptwriter.WriteLine(miscNotesText[i]);
            }
            #endregion
            #region // Character Bio Tab
            ptwriter.WriteLine("<Bio>");
            ptwriter.WriteLine(charAppearanceText);
            ptwriter.WriteLine(charPersonalityText);
            ptwriter.WriteLine(paragraphNumNum);
            for (int j = 0; j < paragraphNumNum; j++)
            {
                ptwriter.WriteLine(charHistoryText[j]);
            }
            #endregion
            #region // Legend Points Tab
            ptwriter.WriteLine("<LegendPoints>");
            ptwriter.WriteLine(legendPointsNum);
            for (int j = 0; j < legendPointsNum; j++)
            {
                ptwriter.WriteLine(legendPointsText[j]);
            }
            #endregion
            ptwriter.Close();
        }

        private void readPlainText()
        {
            int historyLoop = 0;
            int importedParNumNum;
            string miscNotesTemp;
            string lineIn;
            try
            {
                FileStream ptfs = new FileStream(@workingFolder + @"\" + plainTextFile, FileMode.Open, FileAccess.Read);
                using (StreamReader ptReader = new StreamReader(ptfs))
                {
                    
                    while ((lineIn = ptReader.ReadLine()) != null)
                    {
                        #region //Basic Info
                        if (lineIn.Contains("<BasicInfo>"))
                        {
                            nameBox.Text = charName = ptReader.ReadLine();
                            disciplineBox.Text = discName = ptReader.ReadLine();
                            circleBox.Text = circleNum = ptReader.ReadLine();
                            raceBox.Text = raceName = ptReader.ReadLine();
                            genderBox.Text = genderName = ptReader.ReadLine();
                            ageBox.Text = ageNum = ptReader.ReadLine();
                            hairBox.Text = hairName = ptReader.ReadLine();
                            skinBox.Text = skinName = ptReader.ReadLine();
                            eyesBox.Text = eyesName = ptReader.ReadLine();
                            heightBox.Text = heightNum = ptReader.ReadLine();
                            weightBox.Text = weightNum = ptReader.ReadLine();
                            pobBox.Text = pobName = ptReader.ReadLine();
                            resBox.Text = resName = ptReader.ReadLine();
                            passionBox.Text = passionName = ptReader.ReadLine();
                            lSpokenBox.Text = lSpokenName = ptReader.ReadLine();
                            lWrittenBox.Text = lWrittenName = ptReader.ReadLine();
                            dexBaseBox.Text = dexNum = ptReader.ReadLine();
                            dexLPbox.Text = dexLPinc = ptReader.ReadLine();
                            dexCurBox.Text = dexCurNum = ptReader.ReadLine();
                            dexStepBox.Text = dexStepNum = ptReader.ReadLine();
                            dexADbox.Text = dexActDieNum = ptReader.ReadLine();
                            strBaseBox.Text = strNum = ptReader.ReadLine();
                            strLPbox.Text = strLPinc = ptReader.ReadLine();
                            strCurBox.Text = strCurNum = ptReader.ReadLine();
                            strStepBox.Text = strStepNum = ptReader.ReadLine();
                            strADbox.Text = strActDieNum = ptReader.ReadLine();
                            initStepBox.Text = initStepNum = ptReader.ReadLine();
                            initADbox.Text = initActDie = ptReader.ReadLine();
                            touBaseBox.Text = touNum = ptReader.ReadLine();
                            touLPbox.Text = touLPinc = ptReader.ReadLine();
                            touCurBox.Text = touCurNum = ptReader.ReadLine();
                            touStepBox.Text = touStepNum = ptReader.ReadLine();
                            touADbox.Text = touActDieNum = ptReader.ReadLine();
                            perBaseBox.Text = perNum = ptReader.ReadLine();
                            perLPbox.Text = perLPinc = ptReader.ReadLine();
                            perCurBox.Text = perCurNum = ptReader.ReadLine();
                            perStepBox.Text = perStepNum = ptReader.ReadLine();
                            perADbox.Text = perActDieNum = ptReader.ReadLine();
                            wilBaseBox.Text = wilNum = ptReader.ReadLine();
                            wilLPbox.Text = wilLPinc = ptReader.ReadLine();
                            wilCurBox.Text = wilCurNum = ptReader.ReadLine();
                            wilStepBox.Text = wilStepNum = ptReader.ReadLine();
                            wilADbox.Text = wilActDieNum = ptReader.ReadLine();
                            chaBaseBox.Text = chaNum = ptReader.ReadLine();
                            chaLPbox.Text = chaLPinc = ptReader.ReadLine();
                            chaCurBox.Text = chaCurNum = ptReader.ReadLine();
                            chaStepBox.Text = chaStepNum = ptReader.ReadLine();
                            chaADbox.Text = chaActDieNum = ptReader.ReadLine();
                            phyBox.Text = phyDefNum = ptReader.ReadLine();
                            mysBox.Text = mysDefNum = ptReader.ReadLine();
                            SocBox.Text = socDefNum = ptReader.ReadLine();
                            movBox.Text = movNum = ptReader.ReadLine();
                            carryBox.Text = carryNum = ptReader.ReadLine();
                            karmaCurBox.Text = karmaCurNum = ptReader.ReadLine();
                            karmaMaxBox.Text = karmaMaxNum = ptReader.ReadLine();
                            recovTestBox.Text = recovTestNum = ptReader.ReadLine();
                            recovStepBox.Text = recovStepNum = ptReader.ReadLine();
                            recovADbox.Text = recovActDieNum = ptReader.ReadLine();
                            armorBox.Text = armorName = ptReader.ReadLine();
                            shieldBox.Text = shieldName = ptReader.ReadLine();
                            deflectBonusBox.Text = deflectBonusNum = ptReader.ReadLine();
                            phyArmorBox.Text = phyArmNum = ptReader.ReadLine();
                            mysArmorBox.Text = mysDefNum = ptReader.ReadLine();
                            unconBaseBox.Text = uncBaseNum = ptReader.ReadLine();
                            unconAdjBox.Text = uncAdjNum = ptReader.ReadLine();
                            unconCurBox.Text = uncCurNum = ptReader.ReadLine();
                            curDmgBox.Text = dmgCurNum = ptReader.ReadLine();
                            deathBaseBox.Text = deathBaseNum = ptReader.ReadLine();
                            deathAdjBox.Text = deathAdjNum = ptReader.ReadLine();
                            deathCurBox.Text = deathCurNum = ptReader.ReadLine();
                            woundCurBox.Text = woundCurNum = ptReader.ReadLine();
                            woundThreshBox.Text = woundThreshNum = ptReader.ReadLine();
                            woundPenBox.Text = woundPenNum = ptReader.ReadLine();
                        }
                        #endregion
                        #region // Talent Tab
                        if (lineIn.Contains("<Talents>"))
                        {
                            numOfTalents_i = Convert.ToInt32(numOfTalentsBox.Text = ptReader.ReadLine());
                            if (numOfTalents_i >= 1)
                            {
                                talentName01 = talentNameBox01.Text = ptReader.ReadLine();
                                actionType01 = talentActBox01.Text = ptReader.ReadLine();
                                strainYN01 = talentStrainBox01.Text = ptReader.ReadLine();
                                attName01 = talentAttBox01.Text = ptReader.ReadLine();
                                rankNum01 = talentRankBox01.Text = ptReader.ReadLine();
                                talStepNum01 = talentStrainBox01.Text = ptReader.ReadLine();
                                talADnum01 = talentActBox01.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 2)
                            {
                                talentName02 = talentNameBox02.Text = ptReader.ReadLine();
                                actionType02 = talentActBox02.Text = ptReader.ReadLine();
                                strainYN02 = talentStrainBox02.Text = ptReader.ReadLine();
                                attName02 = talentAttBox02.Text = ptReader.ReadLine();
                                rankNum02 = talentRankBox02.Text = ptReader.ReadLine();
                                talStepNum02 = talentStrainBox02.Text = ptReader.ReadLine();
                                talADnum02 = talentActBox02.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 3)
                            {
                                talentName03 = talentNameBox03.Text = ptReader.ReadLine();
                                actionType03 = talentActBox03.Text = ptReader.ReadLine();
                                strainYN03 = talentStrainBox03.Text = ptReader.ReadLine();
                                attName03 = talentAttBox03.Text = ptReader.ReadLine();
                                rankNum03 = talentRankBox03.Text = ptReader.ReadLine();
                                talStepNum03 = talentStrainBox03.Text = ptReader.ReadLine();
                                talADnum03 = talentActBox03.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 4)
                            {
                                talentName04 = talentNameBox04.Text = ptReader.ReadLine();
                                actionType04 = talentActBox04.Text = ptReader.ReadLine();
                                strainYN04 = talentStrainBox04.Text = ptReader.ReadLine();
                                attName04 = talentAttBox04.Text = ptReader.ReadLine();
                                rankNum04 = talentRankBox04.Text = ptReader.ReadLine();
                                talStepNum04 = talentStrainBox04.Text = ptReader.ReadLine();
                                talADnum04 = talentActBox04.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 5)
                            {
                                talentName05 = talentNameBox05.Text = ptReader.ReadLine();
                                actionType05 = talentActBox05.Text = ptReader.ReadLine();
                                strainYN05 = talentStrainBox05.Text = ptReader.ReadLine();
                                attName05 = talentAttBox05.Text = ptReader.ReadLine();
                                rankNum05 = talentRankBox05.Text = ptReader.ReadLine();
                                talStepNum05 = talentStrainBox05.Text = ptReader.ReadLine();
                                talADnum05 = talentActBox05.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 6)
                            {
                                talentName06 = talentNameBox06.Text = ptReader.ReadLine();
                                actionType06 = talentActBox06.Text = ptReader.ReadLine();
                                strainYN06 = talentStrainBox06.Text = ptReader.ReadLine();
                                attName06 = talentAttBox06.Text = ptReader.ReadLine();
                                rankNum06 = talentRankBox06.Text = ptReader.ReadLine();
                                talStepNum06 = talentStrainBox06.Text = ptReader.ReadLine();
                                talADnum06 = talentActBox06.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 7)
                            {
                                talentName07 = talentNameBox07.Text = ptReader.ReadLine();
                                actionType07 = talentActBox07.Text = ptReader.ReadLine();
                                strainYN07 = talentStrainBox07.Text = ptReader.ReadLine();
                                attName07 = talentAttBox07.Text = ptReader.ReadLine();
                                rankNum07 = talentRankBox07.Text = ptReader.ReadLine();
                                talStepNum07 = talentStrainBox07.Text = ptReader.ReadLine();
                                talADnum07 = talentActBox07.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 8)
                            {
                                talentName08 = talentNameBox08.Text = ptReader.ReadLine();
                                actionType08 = talentActBox08.Text = ptReader.ReadLine();
                                strainYN08 = talentStrainBox08.Text = ptReader.ReadLine();
                                attName08 = talentAttBox08.Text = ptReader.ReadLine();
                                rankNum08 = talentRankBox08.Text = ptReader.ReadLine();
                                talStepNum08 = talentStrainBox08.Text = ptReader.ReadLine();
                                talADnum08 = talentActBox08.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 9)
                            {
                                talentName09 = talentNameBox09.Text = ptReader.ReadLine();
                                actionType09 = talentActBox09.Text = ptReader.ReadLine();
                                strainYN09 = talentStrainBox09.Text = ptReader.ReadLine();
                                attName09 = talentAttBox09.Text = ptReader.ReadLine();
                                rankNum09 = talentRankBox09.Text = ptReader.ReadLine();
                                talStepNum09 = talentStrainBox09.Text = ptReader.ReadLine();
                                talADnum09 = talentActBox09.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 10)
                            {
                                talentName10 = talentNameBox10.Text = ptReader.ReadLine();
                                actionType10 = talentActBox10.Text = ptReader.ReadLine();
                                strainYN10 = talentStrainBox10.Text = ptReader.ReadLine();
                                attName10 = talentAttBox10.Text = ptReader.ReadLine();
                                rankNum10 = talentRankBox10.Text = ptReader.ReadLine();
                                talStepNum10 = talentStrainBox10.Text = ptReader.ReadLine();
                                talADnum10 = talentActBox10.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 11)
                            {
                                talentName11 = talentNameBox11.Text = ptReader.ReadLine();
                                actionType11 = talentActBox11.Text = ptReader.ReadLine();
                                strainYN11 = talentStrainBox11.Text = ptReader.ReadLine();
                                attName11 = talentAttBox11.Text = ptReader.ReadLine();
                                rankNum11 = talentRankBox11.Text = ptReader.ReadLine();
                                talStepNum11 = talentStrainBox11.Text = ptReader.ReadLine();
                                talADnum11 = talentActBox11.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 12)
                            {
                                talentName12 = talentNameBox12.Text = ptReader.ReadLine();
                                actionType12 = talentActBox12.Text = ptReader.ReadLine();
                                strainYN12 = talentStrainBox12.Text = ptReader.ReadLine();
                                attName12 = talentAttBox12.Text = ptReader.ReadLine();
                                rankNum12 = talentRankBox12.Text = ptReader.ReadLine();
                                talStepNum12 = talentStrainBox12.Text = ptReader.ReadLine();
                                talADnum12 = talentActBox12.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 13)
                            {
                                talentName13 = talentNameBox13.Text = ptReader.ReadLine();
                                actionType13 = talentActBox13.Text = ptReader.ReadLine();
                                strainYN13 = talentStrainBox13.Text = ptReader.ReadLine();
                                attName13 = talentAttBox13.Text = ptReader.ReadLine();
                                rankNum13 = talentRankBox13.Text = ptReader.ReadLine();
                                talStepNum13 = talentStrainBox13.Text = ptReader.ReadLine();
                                talADnum13 = talentActBox13.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 14)
                            {
                                talentName14 = talentNameBox14.Text = ptReader.ReadLine();
                                actionType14 = talentActBox14.Text = ptReader.ReadLine();
                                strainYN14 = talentStrainBox14.Text = ptReader.ReadLine();
                                attName14 = talentAttBox14.Text = ptReader.ReadLine();
                                rankNum14 = talentRankBox14.Text = ptReader.ReadLine();
                                talStepNum14 = talentStrainBox14.Text = ptReader.ReadLine();
                                talADnum14 = talentActBox14.Text = ptReader.ReadLine();
                            }
                            if (numOfTalents_i >= 15)
                            {
                                talentName15 = talentNameBox15.Text = ptReader.ReadLine();
                                actionType15 = talentActBox15.Text = ptReader.ReadLine();
                                strainYN15 = talentStrainBox15.Text = ptReader.ReadLine();
                                attName15 = talentAttBox15.Text = ptReader.ReadLine();
                                rankNum15 = talentRankBox15.Text = ptReader.ReadLine();
                                talStepNum15 = talentStrainBox15.Text = ptReader.ReadLine();
                                talADnum15 = talentActBox15.Text = ptReader.ReadLine();
                            }
                        }
                        #endregion
                        #region // Misc Notes Tab
                        if (lineIn.Contains("<MiscNotes>"))
                        {
                            miscNotesTemp = ptReader.ReadLine();
                            miscNotesNum = Convert.ToInt32(miscNotesTemp);
                            miscNotesText = new string[miscNotesNum];
                            for (int n = 0; n < miscNotesNum; n++)
                            {
                                miscNotesText[n] = ptReader.ReadLine();
                            }
                            miscNoteBox.Text = string.Join(Environment.NewLine, miscNotesText);
                        }
                        #endregion
                        #region // Character Bio Tab
                        if (lineIn.Contains("<Bio>"))
                        {
                            charAppearanceBox.Text = charAppearanceText = ptReader.ReadLine();
                            charPersonalityBox.Text = charPersonalityText = ptReader.ReadLine();
                            paragrahNumberBox.Text = ptReader.ReadLine();
                            paragraphNumNum = Convert.ToInt32(paragrahNumberBox.Text);
                            importedParNumNum = paragraphNumNum;
                            charHistoryText = new string[paragraphNumNum];
                            for (int i = 0; i < paragraphNumNum; i++)
                            {
                                charHistoryText[i] = ptReader.ReadLine();

                            }
                            charHistoryBox.Text = string.Join(Environment.NewLine, charHistoryText);
                        }
                        #endregion
                        #region // Legend Points Tab
                        if (lineIn.Contains("<LegendPoints>"))
                        {
                            legendPointsNumText = ptReader.ReadLine();
                            legendPointsNum = Convert.ToInt32(legendPointsNumText);
                            legendPointsText = new string[legendPointsNum];
                            for (int i = 0; i < legendPointsNum; i++)
                            {
                                legendPointsText[i] = ptReader.ReadLine();

                            }
                            legendPointBox.Text = string.Join(Environment.NewLine, legendPointsText);
                        }
                        #endregion
                    }
                    ptReader.Close();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("The file, " + plainTextFile + ", cannot be found.\n\nIf this is a new character, please enter the information and save first.");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            plainTextFile = @fileNameBox.Text + @"plaintext.txt";
            int historyCount = 0;
            FileStream fs = new FileStream(@workingFolder + @"\" + workingFilename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            #region // Finished Basic Info
            writer.WriteLine("|8 Earthdawn Character Sheet v2.2  |");
            writer.WriteLine("|--------------------------------|");
            writer.WriteLine("|>! Name : |7< " + charName + " |");
            writer.WriteLine("|>! Discipline : |5< " + discName + " |>! Circle : | " + circleNum + " |");
            writer.WriteLine("|>! Race : |3< " + raceName + " |>! Gender : |< " + genderName + " |>! Age : |< " + ageNum + " |");
            writer.WriteLine("|>! Hair : |3< " + hairName + " |>! Skin : |< " + skinName + " |>! Eyes : |< " + eyesName + " |");
            writer.WriteLine("|>! Height : |5< " + heightNum + " |>! Weight : |< " + weightNum + " |");
            writer.WriteLine("|>! POB : |2< " + pobName + " |>! Residence : |2< " + resName + " |>! Passion : |< " + passionName + " |");
            writer.WriteLine("|>! Language(s) Spoken |3< " + lSpokenName + " |>! Language(s) Written |3< " + lWrittenName + " |");
            writer.WriteLine("|8^ |");
            writer.WriteLine("|>! Attribute |^! Base Value |^! LP Inc. |^! Current |^! Step |^! Action Dice  |2^! Initiative |");
            writer.WriteLine("|>! Dexterity  |^ " + dexNum + " |^ " + dexLPinc + " |^ " + dexCurNum + " |^ " + dexStepNum + " |^ " + dexActDieNum + " |^! Step |^! Action Dice |");
            writer.WriteLine("|>! Strength   |^ " + strNum + " |^ " + strLPinc + " |^ " + strCurNum + " |^ " + strStepNum + " |^ " + strActDieNum + " |^ " + initStepNum + " |^ " + initActDie + " |");
            writer.WriteLine("|>! Toughness  |^ " + touNum + " |^ " + touLPinc + " |^ " + touCurNum + " |^ " + touStepNum + " |^ " + touActDieNum + " |2^! Defense Ratings |");
            writer.WriteLine("|>! Perception |^ " + perNum + " |^ " + perLPinc + " |^ " + perCurNum + " |^ " + perStepNum + " |^ " + perActDieNum + " |>! Physical | " + phyDefNum + " |");
            writer.WriteLine("|>! Willpower  |^ " + wilNum + " |^ " + wilLPinc + " |^ " + wilCurNum + " |^ " + wilStepNum + " |^ " + wilActDieNum + " |>! Mystical | " + mysDefNum + " |");
            writer.WriteLine("|>! Charisma   |^ " + chaNum + " |^ " + chaLPinc + " |^ " + chaCurNum + " |^ " + chaStepNum + " |^ " + chaActDieNum + " |>! Social   | " + socDefNum + " |");
            writer.WriteLine("|8^ |");
            writer.WriteLine("|1.3 |6^! Characteristics |1.3 |");
            writer.WriteLine(" |^! Movement |^! Carry  |^3! Karma - Current |^! Karma - Max |");
            writer.WriteLine(" |^ " + movNum + " |^ " + carryNum + " |^3 " + karmaCurNum + " |^ " + karmaMaxNum + " |");
            writer.WriteLine("|8^ |");
            writer.WriteLine("|1.10 |3^! Health |3^! Armor Ratings |1.10 |");
            writer.WriteLine(" |3^! Recovery                          |>! Armor |2< " + armorName + " |");
            writer.WriteLine(" |^! Tests/Day |^! Step |^! Action Dice |2.1 |^! Defl.Bonus |");
            writer.WriteLine(" |^ " + recovTestNum + " |^ " + recovStepNum + " |^ " + recovActDieNum + " |>! Shield |< " + shieldName + " |^ " + deflectBonusNum + " |");
            writer.WriteLine(" |3^! Unconciousness           |2>! Physical Armor |^ " + phyArmNum + " |");
            writer.WriteLine(" |^! Base  |^! Adj. |^! Current |2>! Mystical Armor |^ " + mysDefNum + " |");
            writer.WriteLine(" |^ " + uncBaseNum + " |^ " + uncAdjNum + " |^ " + uncCurNum + " |2>! Current Damage |^ " + dmgCurNum + " |");
            writer.WriteLine(" |3^! Death                     |3^! Wounds |");
            writer.WriteLine(" |^! Base  |^! Adj. |^! Current |^!Number of |^! Threshold |! Penalty |");
            writer.WriteLine(" |^ " + deathBaseNum + " |^ " + deathAdjNum + " |^ " + deathCurNum + " |^ " + woundCurNum + " |^ " + woundThreshNum + "  |^ " + woundPenNum + " |");
            #endregion
            #region // Talent Tab
            writer.WriteLine("|8^ |");
            writer.WriteLine("|8^! Discipline Talents |");
            writer.WriteLine("|8<! Initiate/Novice    |");
            writer.WriteLine("|2<! Talent Name |^! Action  |^! Strain |^! Attribute |^! + Rank |^!  = Step |^! Action Dice|");
            writer.WriteLine("|2< " + talentName01 + " |^ " + actionType01 + " |^ " + strainYN01 + "  |^ " + attName01 + " |^ " + rankNum01 + " |^ " + talStepNum01 + " | " + talADnum01 + " |");
            if (numOfTalents_i > 1)
                writer.WriteLine("|2< " + talentName02 + " |^ " + actionType02 + " |^ " + strainYN02 + "  |^ " + attName02 + " |^ " + rankNum02 + " |^ " + talStepNum02 + " | " + talADnum02 + " |");
            if (numOfTalents_i > 2)
                writer.WriteLine("|2< " + talentName03 + " |^ " + actionType03 + " |^ " + strainYN03 + "  |^ " + attName03 + " |^ " + rankNum03 + " |^ " + talStepNum03 + " | " + talADnum03 + " |");
            if (numOfTalents_i > 3)
                writer.WriteLine("|2< " + talentName04 + " |^ " + actionType04 + " |^ " + strainYN04 + "  |^ " + attName04 + " |^ " + rankNum04 + " |^ " + talStepNum04 + " | " + talADnum04 + " |");
            if (numOfTalents_i > 4)
                writer.WriteLine("|2< " + talentName05 + " |^ " + actionType05 + " |^ " + strainYN05 + "  |^ " + attName05 + " |^ " + rankNum05 + " |^ " + talStepNum05 + " | " + talADnum05 + " |");
            if (numOfTalents_i > 5)
                writer.WriteLine("|2< " + talentName06 + " |^ " + actionType06 + " |^ " + strainYN06 + "  |^ " + attName06 + " |^ " + rankNum06 + " |^ " + talStepNum06 + " | " + talADnum06 + " |");
            if (numOfTalents_i > 6)
                writer.WriteLine("|2< " + talentName07 + " |^ " + actionType07 + " |^ " + strainYN07 + "  |^ " + attName07 + " |^ " + rankNum07 + " |^ " + talStepNum07 + " | " + talADnum07 + " |");
            if (numOfTalents_i > 7)
                writer.WriteLine("|2< " + talentName08 + " |^ " + actionType08 + " |^ " + strainYN08 + "  |^ " + attName08 + " |^ " + rankNum08 + " |^ " + talStepNum08 + " | " + talADnum08 + " |");
            if (numOfTalents_i > 8)
                writer.WriteLine("|2< " + talentName09 + " |^ " + actionType09 + " |^ " + strainYN09 + "  |^ " + attName09 + " |^ " + rankNum09 + " |^ " + talStepNum09 + " | " + talADnum09 + " |");
            if (numOfTalents_i > 9)
                writer.WriteLine("|2< " + talentName10 + " |^ " + actionType10 + " |^ " + strainYN10 + "  |^ " + attName10 + " |^ " + rankNum10 + " |^ " + talStepNum10 + " | " + talADnum10 + " |");
            if (numOfTalents_i > 10)
                writer.WriteLine("|2< " + talentName11 + " |^ " + actionType11 + " |^ " + strainYN11 + "  |^ " + attName11 + " |^ " + rankNum11 + " |^ " + talStepNum11 + " | " + talADnum11 + " |");
            if (numOfTalents_i > 11)
                writer.WriteLine("|2< " + talentName12 + " |^ " + actionType12 + " |^ " + strainYN12 + "  |^ " + attName12 + " |^ " + rankNum12 + " |^ " + talStepNum12 + " | " + talADnum12 + " |");
            if (numOfTalents_i > 12)
                writer.WriteLine("|2< " + talentName13 + " |^ " + actionType13 + " |^ " + strainYN13 + "  |^ " + attName13 + " |^ " + rankNum13 + " |^ " + talStepNum13 + " | " + talADnum13 + " |");
            if (numOfTalents_i > 13)
                writer.WriteLine("|2< " + talentName14 + " |^ " + actionType14 + " |^ " + strainYN14 + "  |^ " + attName14 + " |^ " + rankNum14 + " |^ " + talStepNum14 + " | " + talADnum14 + " |");
            if (numOfTalents_i > 14)
                writer.WriteLine("|2< " + talentName15 + " |^ " + actionType15 + " |^ " + strainYN15 + "  |^ " + attName15 + " |^ " + rankNum15 + " |^ " + talStepNum15 + " | " + talADnum15 + " |");
            writer.WriteLine("|^8 |");
            writer.WriteLine("|8^! Other Talents |");
            writer.WriteLine("|8<! Initiate/Novice    |");
            writer.WriteLine("|<! Talent Name |^! Karma |^! Action  |^! Strain |^! Attribute |^! + Rank |^! = Step |^! Action Dice|");
            writer.WriteLine("|< Melee Weapons      |^ No     |^ Standard  |^ 0       |^ 7 |^ 3 |^ 10 | 2d8 |");
            writer.WriteLine("|< Parry              |^ No     |^ Standard  |^ 1       |^ 7 |^ 1 |^  9 | d8 + d6 |");
            writer.WriteLine("|8^ |");
            #endregion 
            #region // Misc. Notes Tab
            writer.WriteLine("|8 |");
            writer.WriteLine("|8^! Misc. Notes |");
            for (int i = 0; i < miscNotesNum; i++)
            {
                writer.WriteLine("|8< " + miscNotesText[i] + " |");
                writer.WriteLine("|8 |");
            }
            #endregion

            #region // Legend Points Tab
            writer.WriteLine("|8 |");
            writer.WriteLine("|8^! Legend Points |");
            for (int i = 0; i < legendPointsNum; i++)
            {
                writer.WriteLine("|8< " + legendPointsText[i] + " |");
            }
            #endregion

            writer.Close();
            // Saving the sheet in plaintext to make entry faster, ie not having to redo all of the typing each time.
            savePlainText();
            MessageBox.Show("Your character has been saved to the following file:\n\n\n" + @workingFolder + @"\" + workingFilename);
        }

        #region // Finished Tab 1
        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {
            workingFilename = fileNameBox.Text + @".txt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plainTextFile = @fileNameBox.Text + @"plaintext.txt";
            readPlainText();
            MessageBox.Show("Your character has been reloaded.  Happy editing!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                workingFolder = folderBrowserDialog1.SelectedPath;
            }
            workingPath = @workingFolder + workingFilename;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            charName = nameBox.Text;
        }

        private void disciplineBox_TextChanged(object sender, EventArgs e)
        {
            discName = disciplineBox.Text;
        }

        private void circleBox_TextChanged(object sender, EventArgs e)
        {
            circleNum = circleBox.Text;
        }

        private void raceBox_TextChanged(object sender, EventArgs e)
        {
            raceName = raceBox.Text;
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {
            genderName = genderBox.Text;
        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {
            ageNum = ageBox.Text;
        }

        private void hairBox_TextChanged(object sender, EventArgs e)
        {
            hairName = hairBox.Text;
        }

        private void skinBox_TextChanged(object sender, EventArgs e)
        {
            skinName = skinBox.Text;
        }

        private void eyesBox_TextChanged(object sender, EventArgs e)
        {
            eyesName = eyesBox.Text;
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            heightNum = heightBox.Text;
        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            weightNum = weightBox.Text;
        }

        private void pobBox_TextChanged(object sender, EventArgs e)
        {
            pobName = pobBox.Text;
        }

        private void resBox_TextChanged(object sender, EventArgs e)
        {
            resName = resBox.Text;
        }

        private void passionBox_TextChanged(object sender, EventArgs e)
        {
            passionName = passionBox.Text;
        }

        private void lSpokenBox_TextChanged(object sender, EventArgs e)
        {
            lSpokenName = lSpokenBox.Text;
        }

        private void lWrittenBox_TextChanged(object sender, EventArgs e)
        {
            lWrittenName = lWrittenBox.Text;
        }

        private void dexBaseBox_TextChanged(object sender, EventArgs e)
        {
            dexNum = dexBaseBox.Text;
        }

        private void dexLPbox_TextChanged(object sender, EventArgs e)
        {
            dexLPinc = dexLPbox.Text;
        }

        private void dexCurBox_TextChanged(object sender, EventArgs e)
        {
            dexCurNum = dexCurBox.Text;
        }

        private void dexStepBox_TextChanged(object sender, EventArgs e)
        {
            dexStepNum = dexStepBox.Text;
        }

        private void dexADbox_TextChanged(object sender, EventArgs e)
        {
            dexActDieNum = dexADbox.Text;
        }

        private void strBaseBox_TextChanged(object sender, EventArgs e)
        {
            strNum = strBaseBox.Text;
        }

        private void strLPbox_TextChanged(object sender, EventArgs e)
        {
            strLPinc = strLPbox.Text;
        }

        private void strCurBox_TextChanged(object sender, EventArgs e)
        {
            strCurNum = strCurBox.Text;
        }

        private void strStepBox_TextChanged(object sender, EventArgs e)
        {
            strStepNum = strStepBox.Text;
        }

        private void strADbox_TextChanged(object sender, EventArgs e)
        {
            strActDieNum = strADbox.Text;
        }

        private void touBaseBox_TextChanged(object sender, EventArgs e)
        {
            touNum = touBaseBox.Text;
        }

        private void touLPbox_TextChanged(object sender, EventArgs e)
        {
            touLPinc = touLPbox.Text;
        }

        private void touCurBox_TextChanged(object sender, EventArgs e)
        {
            touCurNum = touCurBox.Text;
        }

        private void touStepBox_TextChanged(object sender, EventArgs e)
        {
            touStepNum = touStepBox.Text;
        }

        private void touADbox_TextChanged(object sender, EventArgs e)
        {
            touActDieNum = touADbox.Text;
        }

        private void perBaseBox_TextChanged(object sender, EventArgs e)
        {
            perNum = perBaseBox.Text;
        }

        private void perLPbox_TextChanged(object sender, EventArgs e)
        {
            perLPinc = perLPbox.Text;
        }

        private void perCurBox_TextChanged(object sender, EventArgs e)
        {
            perCurNum = perCurBox.Text;
        }

        private void perStepBox_TextChanged(object sender, EventArgs e)
        {
            perStepNum = perStepBox.Text;
        }

        private void perADbox_TextChanged(object sender, EventArgs e)
        {
            perLPinc = perLPbox.Text;
        }

        private void wilBaseBox_TextChanged(object sender, EventArgs e)
        {
            wilNum = wilBaseBox.Text;
        }

        private void wilLPbox_TextChanged(object sender, EventArgs e)
        {
            wilLPinc = wilLPbox.Text;
        }

        private void wilCurBox_TextChanged(object sender, EventArgs e)
        {
            wilCurNum = wilCurBox.Text;
        }

        private void wilStepBox_TextChanged(object sender, EventArgs e)
        {
            wilStepNum = wilStepBox.Text;
        }

        private void wilADbox_TextChanged(object sender, EventArgs e)
        {
            wilActDieNum = wilADbox.Text;
        }

        private void chaBaseBox_TextChanged(object sender, EventArgs e)
        {
            chaNum = chaBaseBox.Text;
        }

        private void chaLPbox_TextChanged(object sender, EventArgs e)
        {
            chaLPinc = chaLPbox.Text;
        }

        private void chaCurBox_TextChanged(object sender, EventArgs e)
        {
            chaCurNum = chaCurBox.Text;
        }

        private void chaStepBox_TextChanged(object sender, EventArgs e)
        {
            chaStepNum = chaStepBox.Text;
        }

        private void chaADbox_TextChanged(object sender, EventArgs e)
        {
            chaActDieNum = chaADbox.Text;
        }

        private void initStepBox_TextChanged(object sender, EventArgs e)
        {
            initStepNum = initStepBox.Text;
        }

        private void initADbox_TextChanged(object sender, EventArgs e)
        {
            initActDie = initADbox.Text;
        }

        private void phyBox_TextChanged(object sender, EventArgs e)
        {
            phyDefNum = phyBox.Text;
        }

        private void mysBox_TextChanged(object sender, EventArgs e)
        {
            mysDefNum = mysBox.Text;
        }

        private void SocBox_TextChanged(object sender, EventArgs e)
        {
            socDefNum = SocBox.Text;
        }

        private void movBox_TextChanged(object sender, EventArgs e)
        {
            movNum = movBox.Text;
        }

        private void carryBox_TextChanged(object sender, EventArgs e)
        {
            carryNum = carryBox.Text;
        }

        private void karmaCurBox_TextChanged(object sender, EventArgs e)
        {
            karmaCurNum = karmaCurBox.Text;
        }

        private void karmaMaxBox_TextChanged(object sender, EventArgs e)
        {
            karmaMaxNum = karmaMaxBox.Text;
        }

        private void recovTestBox_TextChanged(object sender, EventArgs e)
        {
            recovTestNum = recovTestBox.Text;
        }

        private void recovStepBox_TextChanged(object sender, EventArgs e)
        {
            recovStepNum = recovStepBox.Text;
        }

        private void recovADbox_TextChanged(object sender, EventArgs e)
        {
            recovActDieNum = recovADbox.Text;
        }

        private void unconBaseBox_TextChanged(object sender, EventArgs e)
        {
            uncBaseNum = unconBaseBox.Text;
        }

        private void unconAdjBox_TextChanged(object sender, EventArgs e)
        {
            uncAdjNum = unconAdjBox.Text;
        }

        private void unconCurBox_TextChanged(object sender, EventArgs e)
        {
            uncCurNum = unconCurBox.Text;
        }

        private void deathBaseBox_TextChanged(object sender, EventArgs e)
        {
            deathBaseNum = deathBaseBox.Text;
        }

        private void deathAdjBox_TextChanged(object sender, EventArgs e)
        {
            deathAdjNum = deathAdjBox.Text;
        }

        private void deathCurBox_TextChanged(object sender, EventArgs e)
        {
            deathCurNum = deathCurBox.Text;
        }

        private void armorBox_TextChanged(object sender, EventArgs e)
        {
            armorName = armorBox.Text;
        }

        private void shieldBox_TextChanged(object sender, EventArgs e)
        {
            shieldName = shieldBox.Text;
        }

        private void deflectBonusBox_TextChanged(object sender, EventArgs e)
        {
            deflectBonusNum = deflectBonusBox.Text;
        }

        private void phyArmorBox_TextChanged(object sender, EventArgs e)
        {
            phyArmNum = phyArmorBox.Text;
        }

        private void mysArmorBox_TextChanged(object sender, EventArgs e)
        {
            mysDefNum = mysArmorBox.Text;
        }

        private void curDmgBox_TextChanged(object sender, EventArgs e)
        {
            dmgCurNum = curDmgBox.Text;
        }

        private void woundCurBox_TextChanged(object sender, EventArgs e)
        {
            woundCurNum = woundCurBox.Text;
        }

        private void woundThreshBox_TextChanged(object sender, EventArgs e)
        {
            woundThreshNum = woundThreshBox.Text;
        }

        private void woundPenBox_TextChanged(object sender, EventArgs e)
        {
            woundPenNum = woundPenBox.Text;
        }
#endregion

        #region // Talent Tab
        private void numOfTalentsBox_TextChanged(object sender, EventArgs e)
        {
            numOfTalents_i = Convert.ToInt32(numOfTalentsBox.Text);
        }

        private void talentNameBox01_TextChanged(object sender, EventArgs e)
        {
            talentName01 = talentNameBox01.Text;
            if (talentNameBox01.Text != null)
            {
                numOfTalents_i = 1;
            }
//            numOfTalentsBox.Text = Convert.ToString(numOfTalents_i);
        }

        private void talentNameBox02_TextChanged(object sender, EventArgs e)
        {
            talentName02 = talentNameBox02.Text;
            if (talentNameBox02.Text != null)
            {
                numOfTalents_i = 2;
            }
        }

        private void talentNameBox03_TextChanged(object sender, EventArgs e)
        {
            talentName03 = talentNameBox03.Text;
            //            numOfTalents_i = 3;
            //            numOfTalentsBox.Text = Convert.ToString(numOfTalents_i);
        }

        private void talentNameBox04_TextChanged(object sender, EventArgs e)
        {
            talentName04 = talentNameBox04.Text;
            //            numOfTalents_i = 4;
            //            numOfTalentsBox.Text = Convert.ToString(numOfTalents_i);
        }

        private void talentNameBox05_TextChanged(object sender, EventArgs e)
        {
            talentName05 = talentNameBox05.Text;
            //            numOfTalents_i = 5;
            //            numOfTalentsBox.Text = Convert.ToString(numOfTalents_i);
        }

        private void talentNameBox06_TextChanged(object sender, EventArgs e)
        {
            talentName06 = talentNameBox06.Text;
            //            numOfTalents_i = 6;
            //            numOfTalentsBox.Text = Convert.ToString(numOfTalents_i);
        }

        private void talentNameBox07_TextChanged(object sender, EventArgs e)
        {
            talentName07 = talentNameBox07.Text;
        }

        private void talentNameBox08_TextChanged(object sender, EventArgs e)
        {
            talentName08 = talentNameBox08.Text;
        }

        private void talentNameBox09_TextChanged(object sender, EventArgs e)
        {
            talentName09 = talentNameBox09.Text;
        }

        private void talentNameBox10_TextChanged(object sender, EventArgs e)
        {
            talentName10 = talentNameBox10.Text;
        }

        private void talentNameBox11_TextChanged(object sender, EventArgs e)
        {
            talentName11 = talentNameBox11.Text;
        }

        private void talentNameBox12_TextChanged(object sender, EventArgs e)
        {
            talentName12 = talentNameBox12.Text;
        }

        private void talentNameBox13_TextChanged(object sender, EventArgs e)
        {
            talentName13 = talentNameBox13.Text;
        }

        private void talentNameBox14_TextChanged(object sender, EventArgs e)
        {
            talentName14 = talentNameBox14.Text;
        }

        private void talentNameBox15_TextChanged(object sender, EventArgs e)
        {
            talentName15 = talentNameBox15.Text;
        }

        #endregion

        #region // Misc. Notes Tab
        private void miscNoteBox_TextChanged(object sender, EventArgs e)
        {
            miscNotesText = miscNoteBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            miscNotesNum = miscNotesText.Length;
            //miscNotesText = miscNoteBox.Text;
        }
        #endregion

        #region // Character Bio Tab
        private void charAppearanceBox_TextChanged(object sender, EventArgs e)
        {
            charAppearanceText = charAppearanceBox.Text;
        }
        private void charPersonalityBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                charPersonalityText = charPersonalityBox.Text;
            }
            catch
            {
                MessageBox.Show("A number greater than zero is required for the Number of Paragraphs box.");
                paragrahNumberBox.Text = "1";
            }
        }

        private void paragrahNumberBox_TextChanged(object sender, EventArgs e)
        {
            paragraphNumNum = Convert.ToInt32(paragrahNumberBox.Text);
        }

        private void charHistoryBox_TextChanged(object sender, EventArgs e)
        {
            charHistoryText = charHistoryBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            paragraphNumNum = charHistoryText.Length;
            paragrahNumberBox.Text = Convert.ToString(paragraphNumNum);
        }
        #endregion

        private void talentActionBox01_TextChanged(object sender, EventArgs e)
        {
            actionType01 = talentActionBox01.Text;
        }

        private void talentActionBox02_TextChanged(object sender, EventArgs e)
        {
            actionType02 = talentActionBox02.Text;
        }

        private void talentActionBox03_TextChanged(object sender, EventArgs e)
        {
            actionType03 = talentActionBox03.Text;
        }

        private void talentActionBox04_TextChanged(object sender, EventArgs e)
        {
            actionType04 = talentActionBox04.Text;
        }

        private void talentActionBox05_TextChanged(object sender, EventArgs e)
        {
            actionType05 = talentActionBox05.Text;
        }

        private void talentActionBox06_TextChanged(object sender, EventArgs e)
        {
            actionType06 = talentActionBox06.Text;
        }

        private void talentActionBox07_TextChanged(object sender, EventArgs e)
        {
            actionType07 = talentActionBox07.Text;
        }

        private void talentActionBox08_TextChanged(object sender, EventArgs e)
        {
            actionType08 = talentActionBox08.Text;
        }

        private void talentActionBox09_TextChanged(object sender, EventArgs e)
        {
            actionType09 = talentActionBox09.Text;
        }

        private void talentActionBox10_TextChanged(object sender, EventArgs e)
        {
            actionType10 = talentActionBox10.Text;
        }

        private void talentActionBox11_TextChanged(object sender, EventArgs e)
        {
            actionType11 = talentActionBox11.Text;
        }

        private void talentActionBox12_TextChanged(object sender, EventArgs e)
        {
            actionType12 = talentActionBox12.Text;
        }

        private void talentActionBox13_TextChanged(object sender, EventArgs e)
        {
            actionType13 = talentActionBox13.Text;
        }

        private void talentActionBox14_TextChanged(object sender, EventArgs e)
        {
            actionType14 = talentActionBox14.Text;
        }

        private void talentActionBox15_TextChanged(object sender, EventArgs e)
        {
            actionType15 = talentActionBox15.Text;
        }

        private void talentStrainBox01_TextChanged(object sender, EventArgs e)
        {
            strainYN01 = talentStrainBox01.Text;
        }

        private void talentStrainBox02_TextChanged(object sender, EventArgs e)
        {
            strainYN02 = talentStrainBox02.Text;
        }

        private void talentStrainBox03_TextChanged(object sender, EventArgs e)
        {
            strainYN03 = talentStrainBox03.Text;
        }

        private void talentStrainBox04_TextChanged(object sender, EventArgs e)
        {
            strainYN04 = talentStrainBox04.Text;
        }

        private void talentStrainBox05_TextChanged(object sender, EventArgs e)
        {
            strainYN05 = talentStrainBox05.Text;
        }

        private void talentStrainBox06_TextChanged(object sender, EventArgs e)
        {
            strainYN06 = talentStrainBox06.Text;
        }

        private void talentStrainBox07_TextChanged(object sender, EventArgs e)
        {
            strainYN07 = talentStrainBox07.Text;
        }

        private void talentStrainBox08_TextChanged(object sender, EventArgs e)
        {
            strainYN08 = talentStrainBox08.Text;
        }

        private void talentStrainBox09_TextChanged(object sender, EventArgs e)
        {
            strainYN09 = talentStrainBox09.Text;
        }

        private void talentStrainBox10_TextChanged(object sender, EventArgs e)
        {
            strainYN10 = talentStrainBox10.Text;
        }

        private void talentStrainBox11_TextChanged(object sender, EventArgs e)
        {
            strainYN11 = talentStrainBox11.Text;
        }

        private void talentStrainBox12_TextChanged(object sender, EventArgs e)
        {
            strainYN12 = talentStrainBox12.Text;
        }

        private void talentStrainBox13_TextChanged(object sender, EventArgs e)
        {
            strainYN13 = talentStrainBox13.Text;
        }

        private void talentStrainBox14_TextChanged(object sender, EventArgs e)
        {
            strainYN14 = talentStrainBox14.Text;
        }

        private void talentStrainBox15_TextChanged(object sender, EventArgs e)
        {
            strainYN15 = talentStrainBox15.Text;
        }

        private void talentAttBox01_TextChanged(object sender, EventArgs e)
        {
            attName01 = talentActionBox01.Text;
        }

        private void talentAttBox02_TextChanged(object sender, EventArgs e)
        {
            attName02 = talentActionBox02.Text;
        }

        private void talentAttBox03_TextChanged(object sender, EventArgs e)
        {
            attName03 = talentActionBox03.Text;
        }

        private void talentAttBox04_TextChanged(object sender, EventArgs e)
        {
            attName04 = talentActionBox04.Text;
        }

        private void talentAttBox05_TextChanged(object sender, EventArgs e)
        {
            attName05 = talentActionBox05.Text;
        }

        private void talentAttBox06_TextChanged(object sender, EventArgs e)
        {
            attName06 = talentActionBox06.Text;
        }

        private void talentAttBox07_TextChanged(object sender, EventArgs e)
        {
            attName07 = talentActionBox07.Text;
        }

        private void talentAttBox08_TextChanged(object sender, EventArgs e)
        {
            attName08 = talentActionBox08.Text;
        }

        private void talentAttBox09_TextChanged(object sender, EventArgs e)
        {
            attName09 = talentActionBox09.Text;
        }

        private void talentAttBox10_TextChanged(object sender, EventArgs e)
        {
            attName10 = talentActionBox10.Text;
        }

        private void talentAttBox11_TextChanged(object sender, EventArgs e)
        {
            attName11 = talentActionBox11.Text;
        }

        private void talentAttBox12_TextChanged(object sender, EventArgs e)
        {
            attName12 = talentActionBox12.Text;
        }

        private void talentAttBox13_TextChanged(object sender, EventArgs e)
        {
            attName13 = talentActionBox13.Text;
        }

        private void talentAttBox14_TextChanged(object sender, EventArgs e)
        {
            attName14 = talentActionBox14.Text;
        }

        private void talentAttBox15_TextChanged(object sender, EventArgs e)
        {
            attName15 = talentActionBox15.Text;
        }

        private void talentRankBox01_TextChanged(object sender, EventArgs e)
        {
            rankNum01 = talentRankBox01.Text;
        }

        private void talentRankBox02_TextChanged(object sender, EventArgs e)
        {
            rankNum02 = talentRankBox02.Text;
        }

        private void talentRankBox03_TextChanged(object sender, EventArgs e)
        {
            rankNum03 = talentRankBox03.Text;
        }

        private void talentRankBox04_TextChanged(object sender, EventArgs e)
        {
            rankNum04 = talentRankBox04.Text;
        }

        private void talentRankBox05_TextChanged(object sender, EventArgs e)
        {
            rankNum05 = talentRankBox05.Text;
        }

        private void talentRankBox06_TextChanged(object sender, EventArgs e)
        {
            rankNum06 = talentRankBox06.Text;
        }

        private void talentRankBox07_TextChanged(object sender, EventArgs e)
        {
            rankNum07 = talentRankBox07.Text;
        }

        private void talentRankBox08_TextChanged(object sender, EventArgs e)
        {
            rankNum08 = talentRankBox08.Text;
        }

        private void talentRankBox09_TextChanged(object sender, EventArgs e)
        {
            rankNum09 = talentRankBox09.Text;
        }

        private void talentRankBox10_TextChanged(object sender, EventArgs e)
        {
            rankNum10 = talentRankBox10.Text;
        }

        private void talentRankBox11_TextChanged(object sender, EventArgs e)
        {
            rankNum11 = talentRankBox11.Text;
        }

        private void talentRankBox12_TextChanged(object sender, EventArgs e)
        {
            rankNum12 = talentRankBox12.Text;
        }

        private void talentRankBox13_TextChanged(object sender, EventArgs e)
        {
            rankNum13 = talentRankBox13.Text;
        }

        private void talentRankBox14_TextChanged(object sender, EventArgs e)
        {
            rankNum14 = talentRankBox14.Text;
        }

        private void talentRankBox15_TextChanged(object sender, EventArgs e)
        {
            rankNum15 = talentRankBox15.Text;
        }

        private void talentStepBox01_TextChanged(object sender, EventArgs e)
        {
            talStepNum01 = talentStepBox01.Text;
        }

        private void talentStepBox02_TextChanged(object sender, EventArgs e)
        {
            talStepNum02 = talentStepBox02.Text;
        }

        #region // Legend Points Tab
        private void legendPointBox_TextChanged(object sender, EventArgs e)
        {
            legendPointsText = legendPointBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            legendPointsNum = legendPointsText.Length;
        }
        #endregion
    }
}
