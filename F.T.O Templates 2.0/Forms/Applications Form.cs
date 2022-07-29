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
    public partial class Applications_Form : Form
    {
        public Applications_Form()
        {
            InitializeComponent();
        }

        private void pint_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            var text = @"

[COLOR=#D3D3D3]
[LIST][*](( Kindly join the [URL=""https://hzgaming.net/factiondiscord/""]Faction Discord[/URL] server and edit your name into ""[P. INT] Full Name"". ))[*](( Wait inside the ""Lobby"" under '1.) LSPD' category for your Interview which you will be dragged by a representative from FTO. ))[*]You have a week (7 days) to schedule an interview, otherwise, your application will get denied.[/LIST]
[/COLOR]




[COLOR=#00bfff]After completing a successful interview, you will be eligible to attend the recruitment drive, about which you'll receive an e-mail soon enough. Failure to attend the interview before the recruitment drive will result in you being put on hold and shifted for the next recruitment drive.[/COLOR][COLOR=#D3D3D3]


[/COLOR][COLOR=#00bfff]Sincerely,
[/COLOR][COLOR=#D3D3D3]
[/COLOR][COLOR=#00bfff][B][I]" + rankandfullname.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Pending Interview response copied successfully.");
        }

        private void pbdg_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Wiegler
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/IBVmDfV.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

We, field training division of the Los Santos Police Department [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]congratulate [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]you on your [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]success [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]in the Interview. Now you must wait for a representative from the top hierarchy team that will be a member of the leadership team, however, to get your badge there must be a field training instructor available to conduct your very first phase, which is the theory training. Follow the following steps to continue in your employment path:
[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]

[LIST][*](( Head to HZRP factions discord - hzgaming.net/factionsdiscord - Stay in the 'lobby' under LSPD category with your nickname set to [P. Badge] First and Lastname.))[*]A representative from the Leadership Staff will give you the cadet badge.[/LIST]
[/FONT][/COLOR][FONT=Century Gothic]

[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#ffffff][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]


[COLOR=#00bfff]Sincerely,[/COLOR]
[B][COLOR=#00bfff][I]" + rankandfullname.Text + @"[/I][/COLOR][COLOR=#FFFFFF]
[/COLOR][/B][COLOR=#00bfff]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Pending Badge response copied successfully.");
        }

        private void hired_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Wiegler
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/8Anz9JF.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00BFFF][FONT=&amp][FONT=century gothic]Dear Applicant,


After reviewing your performance during the recruitment drive,[/FONT] [FONT=century gothic]we are pleased to inform you that you have been [/FONT][/FONT][/COLOR][FONT=century gothic][COLOR=#00FF00]ACCEPTED [/COLOR][/FONT][FONT=Century Gothic][COLOR=#00bfff]to join the Los Santos Police Department as a Cadet of the Academy.[/COLOR][/FONT]

[FONT=Century Gothic][COLOR=#00bfff]You have successfully completed the first two steps of the Recruitment Procedure and are now ready to receive a series of trainings to shape you into an Officer of the future.[/COLOR][/FONT]

[FONT=Century Gothic][COLOR=#00bfff]You will now be referred to the training instructors, to learn the essentials of being a Law Enforcement Officer. In these sessions, we expect nothing but your best.[/COLOR][/FONT]
[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL] |  [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] | [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#ffffff][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]


[COLOR=#00bfff][FONT=century gothic]After completing a successful interview, you will be eligible to attend the recruitment drive, about which you'll receive an e-mail soon enough. Failure to attend the interview before the recruitment drive will result in you being put on hold and shifted for the next recruitment drive.[/FONT]
[/COLOR]
[COLOR=#00bfff][FONT=century gothic]Sincerely,

[B][I]" + rankandfullname.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/FONT][/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]



[CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Hired response copied successfully.");
        }

        private void accepted_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Wiegler
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/alHXmN8.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

We'd like to congratulate you as you have successfully [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]passed [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]the Officer Introductory Exam (OIE), hence your [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]promotion [/FONT][/COLOR][FONT=Century Gothic][COLOR=#00bfff]to the officer rank has been decided by the leadership staff. Follow these next steps to complete the required document work to register yourself as an official member and to receive the new badge.[/COLOR][/FONT]
[COLOR=#D3D3D3][FONT=Century Gothic]

[LIST][*]Head to the personnel management office and create your personnel profile.[*]Request for a new unused badge number in the personnel management office.[*]A representative from the Leadership Staff will give you the new officer badge.[/LIST]

[COLOR=#00ff00]Welcome to [/COLOR][COLOR=#00bfff]Los Santos Police Department[/COLOR][COLOR=#00ff00] and we wish you the best of luck in your new journey.[/COLOR]
[/FONT][/COLOR][FONT=Century Gothic]
[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#AFEEEE][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]

[COLOR=#00bfff]Sincerely,
[B][I]" + rankandfullname.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Accepted response copied successfully.");
        }

        private void onhold_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (reasons.Text == String.Empty)
            {
                MessageBox.Show("Please enter a reason for putting an application ON-HOLD (use " + "[*]" + " to put the second reason, and so on.");
                return;
            }
            else
            {
                var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Bishop
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/D0fB4n1.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1]
[/SIZE][/COLOR][/RIGHT]
[/FONT][CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been reviewed by the Field Training and Operations branch of the Los Santos Police Department. After reviewing your application, we found some minor errors that will need to be fixed so we can proceed with your application. 

The following section(s) need to be [/FONT][/COLOR][B][COLOR=#ffffff][FONT=Century Gothic]FIXED [/FONT][/COLOR][/B][COLOR=#00bfff][FONT=Century Gothic]within the next 48 hours:[/FONT][/COLOR][COLOR=#FFFFFF][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + reasons.Text + @"[/LIST]
[/B][/FONT][/COLOR][FONT=Century Gothic][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/403491-LSPD-Career-Information""]Police Academy Process[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/335311-LSPD-Requirements""]Enrollment Requirements[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Official Police Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#AFEEEE][I]It is important that you actively review the manual as you begin resuming your career within our department for further knowledge sustenance.[/I][/COLOR][/INDENT]


[COLOR=#00bfff]Please keep in mind that you only have a maximum of 48 hours to fix your application or it shall be automatically [/COLOR][COLOR=#ff0000]denied[/COLOR][COLOR=#00bfff]. 
[/COLOR][COLOR=#D3D3D3]
[/COLOR][COLOR=#00bfff]Sincerely,[/COLOR][COLOR=#D3D3D3]

[/COLOR][COLOR=#00bfff][B][I]" + rankandfullname.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
                Clipboard.SetText(text);
                MessageBox.Show("ON-HOLD response copied successfully.");
            }


        }

        private void denied_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (reasons.Text == String.Empty)
            {
                MessageBox.Show("Please enter a reason for denying an application  (use " + "[*]" + " to put the second reason, and so on.");
                return;
            }
            else
            {
                var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Bishop
64th Administration
16/07/22[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/tXgwI10.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been reviewed by the Field Training and Operations division of the Los Santos Police Department. 

[/FONT][/COLOR][COLOR=#00bfff]After reviewing all information received throughout the selection process, we regret to inform you that your applicant has been [/COLOR][COLOR=#ff0000]DENIED[/COLOR][COLOR=#00bfff].[/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]
 
[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]You were [/FONT][/COLOR][COLOR=#ff0000][FONT=Century Gothic]denied[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic] for employment due to the following reason(s):

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + reasons.Text + @"[/LIST]
[/B][/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]
[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]Please feel free to correct any issues above and re-apply when we start the next recruitment drive for the department. Be advised of the following exigencies:[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]


[LIST][*]Unable to try again at employment until the next batch (( [B][U]2[/U][/B] weeks )).[*]Unable to continue in the recruitment process or claim you are currently enrolled.[*]Applying in less than 14 days will lead you to be [SIZE=2][COLOR=#B22222]Blacklisted.[/COLOR][/SIZE][/LIST]

[/FONT][/COLOR][COLOR=#ffd700]It is important that you actively review our handbook to understand and acknowledge our standards and learn more about us.[/COLOR] [COLOR=#D3D3D3][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]Sincerely,[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]

[/FONT][/COLOR][I][COLOR=#00bfff][FONT=Century Gothic][B]" + rankandfullname.Text+@"
[/B][/FONT][/COLOR][/I][COLOR=#00bfff][FONT=Century Gothic][I]Field Training Operations
[/I][/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic][I]Los Santos Police Department[/I][/FONT][/COLOR]


[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/TD]
[/TR]
[/TABLE]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            
                Clipboard.SetText(text);
                MessageBox.Show("Denied response copied successfully.");

            }
            
        }

        private void closed_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (reasons.Text == String.Empty)
            {
                MessageBox.Show("Please enter a reason for denying an application  (use " + "[*]" + " to put the second reason, and so on.");
                return;
            }
            else
            {
                var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Bishop
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/Fgi9J4P.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1]
[/SIZE][/COLOR][/RIGHT]
[/FONT][CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 700, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been brought to our attention; also it has been reviewed by our Field Training Operations team and due to some major reasons we have decided to conclude your application with the [/FONT][/COLOR][B][COLOR=#ffffff][FONT=Century Gothic]CLOSED [/FONT][/COLOR][/B][COLOR=#00bfff][FONT=Century Gothic]status for the following reasons:[/FONT][/COLOR][COLOR=#FFFFFF][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + reasons.Text + @"[/LIST]
[/B][/FONT][/COLOR][FONT=Century Gothic][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/403491-LSPD-Career-Information""]Police Academy Process[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/335311-LSPD-Requirements""]Enrollment Requirements[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Official Police Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#ffffff][I]It is important that you actively review the manual as you begin resuming your career within our department for further knowledge sustenance.[/I][/COLOR][/INDENT]
[COLOR=#FFFFFF]
[/COLOR][COLOR=#00ff00]If you have any questions or additional information, please mail it to our field training officers.[/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff]Sincerely,[/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff][B][I]" + rankandfullname.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
                Clipboard.SetText(text);
                MessageBox.Show("Closed response copied successfully.");
            }
        }

        private void blacklisted_Click(object sender, EventArgs e)
        {
            if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (rankandfullname.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Rank & Full Name");
                return;
            }
            else if (reasons.Text == String.Empty)
            {
                MessageBox.Show("Please enter a reason for denying an application  (use " + "[*]" + " to put the second reason, and so on.");
                return;
            }
            else
            {
                var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Jaz Bishop
64th Administration
16/07/2022[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/GZBzb2x.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1]
[/SIZE][/COLOR][/RIGHT]
[/FONT][CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][FONT=century gothic][COLOR=#00bfff]Dear Applicant,

After having a review of your application in the officer of Field Training Operations, we regret to inform you that your application has been [/COLOR][B][COLOR=#ff0000]DENIED [/COLOR][/B][COLOR=#00bfff]along with a Recruitment Ban. [/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff]With the [/COLOR][B][COLOR=#b22222]blacklisted [/COLOR][/B][COLOR=#00bfff]status, you are of the following:[/COLOR][/FONT][COLOR=#FFFFFF][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + reasons.Text + @"[/LIST]
[/B][/FONT][/COLOR]
[FONT=Century Gothic][quote][FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/448872-LSPD-Recruitment-Blacklist""][CENTER]Enclosed within - Recruitment Blacklist[/CENTER]
[/URL][/FONT][/quote]
[COLOR=#FFFFFF]
[/COLOR][COLOR=#00bfff]You can check your recruitment ban by clicking the attachment foreseen above.
[/COLOR][COLOR=#FFFFFF]
[/COLOR][COLOR=#00bfff]Sincerely,[/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff][B][I]" + rankandfullname.Text+@"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
                Clipboard.SetText(text);
                MessageBox.Show("Blacklisted response copied successfully.");
            }
            }
    }

}
