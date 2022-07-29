using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.T.O_Templates_2._0.Forms
{
    public partial class Training_Files_Form : Form
    {
        public Training_Files_Form()
        {
            InitializeComponent();
        }
        string mic = "";
        string rp = "";
        string rules = "";
        string eng = "";
        string trainingname = "";
        string result = "";
        int ridealong = 0;
        int OIE = 0;
        private void checkBoxesTF()
        {
            if (cdtapp.Text == String.Empty || cdtname.Text == String.Empty || cdtdiscid.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more textboxes are left empty!");
                return;
            }
            if (enggood.CheckState == CheckState.Unchecked && engavg.CheckState == CheckState.Unchecked && engbad.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please rate the quality of his English.");
                return;
            }
            else if (rulesgood.CheckState == CheckState.Unchecked && rulesavg.CheckState == CheckState.Unchecked && rulesbad.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please rate the his Server Rules Knowledge.");
                return;
            }
            else if (micgood.CheckState == CheckState.Unchecked && micavg.CheckState == CheckState.Unchecked && micbad.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please rate the quality of his Microphone.");
                return;
            }
            else if (rpgood.CheckState == CheckState.Unchecked && rpavg.CheckState == CheckState.Unchecked && rpbad.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please rate the quality of his Roleplay.");
                return;
            }
            if (enggood.CheckState == CheckState.Checked && engavg.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (enggood.CheckState == CheckState.Checked && engbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (engavg.CheckState == CheckState.Checked && engbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (enggood.CheckState == CheckState.Checked && engavg.CheckState == CheckState.Checked && engbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            if (rulesgood.CheckState == CheckState.Checked && rulesavg.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rulesgood.CheckState == CheckState.Checked && rulesbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rulesavg.CheckState == CheckState.Checked && rulesbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rulesgood.CheckState == CheckState.Checked && rulesavg.CheckState == CheckState.Checked && rulesbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            if (micgood.CheckState == CheckState.Checked && micavg.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (micgood.CheckState == CheckState.Checked && micbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (micavg.CheckState == CheckState.Checked && micbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (micgood.CheckState == CheckState.Checked && micavg.CheckState == CheckState.Checked && micbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            if (rpgood.CheckState == CheckState.Checked && rpavg.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rpgood.CheckState == CheckState.Checked && rpbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rpavg.CheckState == CheckState.Checked && rpbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            else if (rpgood.CheckState == CheckState.Checked && rpavg.CheckState == CheckState.Checked && rpbad.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one checkbox!");
                return;
            }
            if (enggood.CheckState == CheckState.Checked)
            {
                eng = "[COLOR=#00FF00][B] GOOD[/B][/COLOR]";
            }
            else if (engavg.CheckState == CheckState.Checked)
            {
                eng = "[B][COLOR=#D3D3D3] AVERAGE[/COLOR][/B]";
            }
            else if (engbad.CheckState == CheckState.Checked)
            {
                eng = "[B][COLOR=#FF0000] BAD[/COLOR][/B]";
            }
            if (micgood.CheckState == CheckState.Checked)
            {
                mic = "[COLOR=#00FF00][B] GOOD[/B][/COLOR]";
            }
            else if (micavg.CheckState == CheckState.Checked)
            {
                mic = "[B][COLOR=#D3D3D3] AVERAGE[/COLOR][/B]";
            }
            else if (micbad.CheckState == CheckState.Checked)
            {
                mic = "[B][COLOR=#FF0000] BAD[/COLOR][/B]";
            }
            if (rpgood.CheckState == CheckState.Checked)
            {
                rp = "[COLOR=#00FF00][B] GOOD[/B][/COLOR]";
            }
            else if (rpavg.CheckState == CheckState.Checked)
            {
                rp = "[B][COLOR=#D3D3D3] AVERAGE[/COLOR][/B]";
            }
            else if (rpbad.CheckState == CheckState.Checked)
            {
                rp = "[B][COLOR=#FF0000] BAD[/COLOR][/B]";
            }
            if (rulesgood.CheckState == CheckState.Checked)
            {
                rules = "[COLOR=#00FF00][B] GOOD[/B][/COLOR]";
            }
            else if (rulesavg.CheckState == CheckState.Checked)
            {
                rules = "[B][COLOR=#D3D3D3] AVERAGE[/COLOR][/B]";
            }
            else if (rulesbad.CheckState == CheckState.Checked)
            {
                rules = "[B][COLOR=#FF0000] BAD[/COLOR][/B]";
            }
        } // to check the functions of all input methods, 155 lines  of nasted "if"


        private void button1_Click(object sender, EventArgs e)
        {
            checkBoxesTF();
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Bishop
64th Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Cadet Training File[/FONT][/COLOR][/SIZE][/FONT][/LEFT]


[CENTER][IMG]https://i.imgur.com/8swdbnP.png[/IMG]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][SIZE=5][COLOR=#D3D3D3]TRAINING FILE[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[/CENTER]

[SIZE=4][FONT=Verdana][COLOR=ROYALBLUE][u][b][center]CADET'S INFORMATION[/center][/b][/u][/COLOR][u][b][center][/center][/b][/u][/FONT][/SIZE][FONT=Verdana][u][b][center][/center][/b][/U][b][center][/center][/B][center][/center][/FONT][center][/CENTER]


[list][COLOR=#2B60DE][B]Full Name[/B]:[/COLOR] [COLOR=#D3D3D3]" + cdtname.Text + @"[/COLOR]

[COLOR=#2B60DE][B][*]Police Application:[/B][/COLOR] [URL=""" + cdtapp.Text + @"""]** ATTACHMENT **[/URL]

[COLOR=#2b60de][B][*]Discord ID: [/B][/COLOR] [COLOR=#D3D3D3]" + cdtdiscid.Text + @"[/COLOR]



[SIZE=4][FONT=Verdana][COLOR=ROYALBLUE][u][b][center](( EVALUATION OF PERFORMANCE ))[/center][/b][/u][/COLOR][u][b][center][/center][/b][/u][/FONT][/SIZE][FONT=Verdana][u][b][center][/center][/b][/U][b][center][/center][/B][center][/center][/FONT][center][/CENTER]


[COLOR=#2B60DE][B][*]Microphone Quality:[/B][/COLOR]" + mic + @"

[COLOR=#2B60DE][B][*]English Skills:[/B][/COLOR]" + eng + @"

[COLOR=#2B60DE][B][*]Roleplay Skills:[/B][/COLOR]" + rp + @"

[COLOR=#2B60DE][B][*]Server Rules Knowledge:[/B][/COLOR]" + rules + @"
[/list]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Generated a Training File Template.");

        }

        private void training_Click(object sender, EventArgs e)
        {
            if (theory.CheckState == CheckState.Unchecked && practical.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show(@"Please select the type of training (""Theory / Practical"")");
                return;
            }
            else if (theory.CheckState == CheckState.Checked && practical.CheckState == CheckState.Checked)
            {
                MessageBox.Show(@"Please select only ONE training (""Theory / Practical"")");
                return;
            }
            else if (trainername.Text == String.Empty || evaluation.Text == String.Empty || supervisor.Text == String.Empty)
            {
                MessageBox.Show("Please fill up the following: Supervisor, Trainer's Rank & Name and Evaluation");
                return;
            }
            else
            {
                if (theory.CheckState == CheckState.Checked)
                {
                    trainingname = " Theory";
                }
                else if (practical.CheckState == CheckState.Checked)
                {
                    trainingname = " Practical";
                }
                var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/8swdbnP.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][FONT=System][SIZE=5][COLOR=#336699][COLOR=#094a85] [SIZE=4]★[/SIZE] TRAINING COMPLETED [SIZE=4]★ [/SIZE][/COLOR][/COLOR][/SIZE][/FONT][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]


[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]TRAINER: [/B][/COLOR][COLOR=WHITE]" + trainername.Text + @"[/COLOR][COLOR=#e6e6fa]

[/COLOR][B][COLOR=#1E90FF]TRAINING COMPLETED:[/COLOR][/B][COLOR=WHITE]" + trainingname + @"[/COLOR]
[COLOR=#1E90FF]
[B]SUPERVISORY TRAINER:[/B][/COLOR] [COLOR=WHITE]" + supervisor.Text + @"[/COLOR]

[COLOR=#1E90FF][B]EVALUATION:[/B][/COLOR] [color=WHITE] " + evaluation.Text + @"

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
                Clipboard.SetText(text);
                MessageBox.Show("Training Completed has been copied successfully to your clipboard.");
            }

        }
        private void retraining_Click(object sender, EventArgs e)
        {
            if (theory.CheckState == CheckState.Unchecked && practical.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show(@"Please select the type of training (""Theory / Practical"")");
                return;
            }
            else if (theory.CheckState == CheckState.Checked && practical.CheckState == CheckState.Checked)
            {
                MessageBox.Show(@"Please select only ONE training (""Theory / Practical"")");
                return;
            }
            else if (trainername.Text == String.Empty || evaluation.Text == String.Empty)
            {
                MessageBox.Show("Please fill up the following: Supervisor, Trainer's Rank & Name and Evaluation");
                return;
            }
            else
            {
                if (theory.CheckState == CheckState.Checked)
                {
                    trainingname = " Theory";
                }
                else if (practical.CheckState == CheckState.Checked)
                {
                    trainingname = " Practical";
                }
                var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/8swdbnP.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[b][size=5][COLOR=YELLOW] ★RE-TRAINING IN PROGRESS★[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]TRAINER: [/B][/COLOR][COLOR=#e6e6fa]" + trainername.Text + @"[/COLOR]

[COLOR=#1E90FF][B]PROGRESSION:[/B][/COLOR] [COLOR=WHITE]" + trainingname + @"[/COLOR]

[COLOR=#1E90FF][B]NOTES: [/B][/COLOR][COLOR=#e6e6fa] " + evaluation.Text + @"[/COLOR][COLOR=#D3D3D3]

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            }


        }
        private void racompleted_Click(object sender, EventArgs e)
        {
            if (trainername.Text == String.Empty || evaluation.Text == String.Empty)
            {
                MessageBox.Show("Please fill out the trainer's rank and name, and/or the evaluation");
                return;
            }
            if (ra1.CheckState == CheckState.Unchecked && ra2.CheckState == CheckState.Unchecked && ra3.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please select the number of the Ridealong");
                return;
            }
            else if (ra1.CheckState == CheckState.Checked && ra2.CheckState == CheckState.Checked && ra3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (ra1.CheckState == CheckState.Checked && ra2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (ra1.CheckState == CheckState.Checked && ra3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (ra2.CheckState == CheckState.Checked && ra3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            if (passed.CheckState == CheckState.Checked && failed.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only ONE result, either passed or failed!");
                return;
            }
            else if (passed.CheckState == CheckState.Unchecked && failed.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please select the result, either passed or failed!");
                return;
            }
            if (ra1.CheckState.Equals(CheckState.Checked))
            {
                ridealong = 1;
            }
            else if (ra2.CheckState.Equals(CheckState.Checked))
            {
                ridealong = 2;
            }
            else if (ra3.CheckState.Equals(CheckState.Checked))
            {
                ridealong = 3;
            }
            if (passed.CheckState == CheckState.Checked)
            {
                result = "[COLOR=#00FF00] PASSED[/COLOR]";
            }
            else if (failed.CheckState == CheckState.Checked)
            {
                result = "[COLOR=#FF0000] FAILED[/COLOR]";
            }
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/8swdbnP.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][FONT=System][SIZE=5][COLOR=#336699][COLOR=#094a85] [SIZE=4]★[/SIZE] RIDEALONG COMPLETED [SIZE=4]★ [/SIZE][/COLOR][/COLOR][/SIZE][/FONT][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]RIDEALONG SUPERVISOR: [/B][/COLOR][COLOR=WHITE]" + trainername.Text + @"[/COLOR][COLOR=#e6e6fa]

[/COLOR][B][COLOR=#1e90ff]RIDEALONG COMPLETED:[/COLOR][/B][COLOR=WHITE] " + ridealong + @"[/COLOR]

[COLOR=#1E90FF][B]RIDEALONG RESULTS:[/B][/COLOR] " + result + @"

[COLOR=#1E90FF][B]EVALUATION:[/B][/COLOR] [COLOR=WHITE] " + evaluation.Text + @"

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Ridealong response has been copied successfully to your clipboard");
        }
        private void oiedone_Click(object sender, EventArgs e)
        {
            if (trainername.Text == String.Empty || evaluation.Text == String.Empty || supervisor.Text == String.Empty)
            {
                MessageBox.Show("Please fill out the trainer's rank and name, supervisor, and/or the evaluation");
                return;
            }
            else if (oie1.CheckState == CheckState.Unchecked && oie2.CheckState == CheckState.Unchecked && oie3.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please select the number of the Ridealong");
                return;
            }
            else if (oie1.CheckState == CheckState.Checked && oie2.CheckState == CheckState.Checked && oie3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (oie1.CheckState == CheckState.Checked && oie2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (oie1.CheckState == CheckState.Checked && oie3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            else if (oie2.CheckState == CheckState.Checked && oie3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only one ridealong.");
                return;
            }
            if (passed.CheckState == CheckState.Checked && failed.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Please select only ONE result, either passed or failed!");
                return;
            }
            else if (passed.CheckState == CheckState.Unchecked && failed.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please select the result, either passed or failed!");
                return;
            }
            if (oie1.CheckState.Equals(CheckState.Checked))
            {
                OIE = 1;
            }
            else if (oie2.CheckState.Equals(CheckState.Checked))
            {
                OIE = 2;
            }
            else if (oie3.CheckState.Equals(CheckState.Checked))
            {
                OIE = 3;
            }
            if (passed.CheckState == CheckState.Checked)
            {
                result = "[COLOR=#00FF00] PASSED[/COLOR]";
            }
            else if (failed.CheckState == CheckState.Checked)
            {
                result = "[COLOR=#FF0000] FAILED[/COLOR]";
            }
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/7UoQMbh.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][SIZE=5][COLOR=GREEN] [COLOR=""#003366""]★ FINISHED OIE ★[/COLOR][/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#ffffff][B]OIE RESULTS:[/B][/COLOR]" + result + @"

[COLOR=WHITE][B]OIE NUMBER:[/B] " + OIE + @"

[B]OIE GIVEN BY:[/B] " + trainername.Text + @"

[B]SUPERVISED BY:[/B] " + supervisor.Text + @"

[B]NOTES:[/B] " + evaluation + @"

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("OIE response has been copied successfully to your clipboard");
        }
        private void disqualified_Click(object sender, EventArgs e)
        {
            if (evaluation.Text == String.Empty)
            {
                MessageBox.Show("Please fill up the reason for disqualification in the evaluation field. ");
                return;
            }
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][IMG]https://i.imgur.com/8swdbnP.png[/IMG]        

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][SIZE=5][COLOR=RED][COLOR=""#003366""][COLOR=""#FF0000""]★ [COLOR=""#FF0000""]DISQUALIFIED[/COLOR] ★[/COLOR][/COLOR][/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]
[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#D3D3D3][B]Reason: [/B][/COLOR][COLOR=#e6e6fa]"+evaluation.Text+@"[/COLOR][COLOR=#D3D3D3]


[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Disqualified response has been copied successfully to your clipboard");
        }
        private void pendingoie_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/8swdbnP.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT]
[B][FONT=System][SIZE=5][COLOR=#336699][COLOR=#094a85] [SIZE=4]★[/SIZE] Pending OIE [SIZE=4]★ [/SIZE][/COLOR][/COLOR][/SIZE][/FONT][/B]
[/CENTER]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[/TD]
[/TR]
[/TABLE]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=WHITE][FONT=TIMES NEW ROMAN]The applicant has successfully finished their 3 Ride Alongs, 24 hours has also passed and they're now eligible for their OIE.[/FONT][/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Pending OIE response has been copied successfully to your clipboard");
        }
        private void pridealongs_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/8swdbnP.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][FONT=System][SIZE=5][COLOR=#336699][COLOR=#094a85] [SIZE=4]★[/SIZE] PENDING RIDEALONGS [SIZE=4]★ [/SIZE][/COLOR][/COLOR][/SIZE][/FONT][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]
[/TD]
[/TR]
[/TABLE]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=WHITE][FONT=TIMES NEW ROMAN]The applicant is to have 3 ridealongs conducted by a FTO General Instructor+ or any Sergeant+ of any division. These ridealongs must be filed through our #ridealong channel on discord in order to be counted and documented by FTO Supervisor+ on the Cadets Training File.[/FONT][/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Pending Ridealongs response has been copied successfully to your clipboard");
        }
    }
}
