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
               karmaMaxNum, armorName, recovTestNum, recovStepNum, recovActDieNum, shieldName, deflectBonusNum, phyArmNum, uncBaseNum,
               uncAdjNum, uncCurNum, dmgCurNum, deathBaseNum, deathAdjNum, deathCurNum, woundCurNum, woundThreshNum, 
               woundPenNum;


        public Form1()
        {
            InitializeComponent();
        }

        private void savePlainText()
        {
            FileStream ptfs = new FileStream(@workingFolder + @"\" + plainTextFile, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ptwriter = new StreamWriter(ptfs);
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
            ptwriter.Close();
        }

        private void readPlainText()
        {
            try
            {
                FileStream ptfs = new FileStream(@workingFolder + @"\" + plainTextFile, FileMode.Open, FileAccess.Read);
                using (StreamReader ptReader = new StreamReader(ptfs))
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
            FileStream fs = new FileStream(@workingFolder + @"\" + workingFilename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
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
            writer.WriteLine(" |^! Base  |^! Adj. |^! Current |2>! Mystical Armor |^ 2|");
            writer.WriteLine(" |^ " + uncBaseNum + " |^ " + uncAdjNum + " |^ " + uncCurNum + " |2>! Current Damage |^ " + dmgCurNum + " |");
            writer.WriteLine(" |3^! Death                     |3^! Wounds |");
            writer.WriteLine(" |^! Base  |^! Adj. |^! Current |^!Number of |^! Threshold |! Penalty |");
            writer.WriteLine(" |^ " + deathBaseNum + " |^ " + deathAdjNum + " |^ " + deathCurNum + " |^ " + woundCurNum + " |^ " + woundThreshNum + "  |^ " + woundPenNum + " |");
            writer.WriteLine("|8^ |");
            writer.Close();
            // Saving the sheet in plaintext to make entry faster, ie not having to redo all of the typing each time.
            savePlainText();
            MessageBox.Show("Your character has been saved to the following file:\n\n\n" + @workingFolder + @"\" + workingFilename);
        }

        #region //Finished stuff
        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {
            workingFilename = fileNameBox.Text + @".txt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plainTextFile = fileNameBox.Text + @"plaintext.txt";
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
        #endregion 

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
    }
}
