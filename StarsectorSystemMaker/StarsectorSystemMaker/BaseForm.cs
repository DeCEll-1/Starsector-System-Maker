using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarsectorSystemMaker
{
    public partial class BaseForm : Form
    {


        public BaseForm()
        {
            InitializeComponent();

            try
            {
                Statics.AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                FileInfo ficonfig = new FileInfo(Statics.AppPath + "/config.txt");

                FileInfo fihelp = new FileInfo(Statics.AppPath + "/help.txt");

                DirectoryInfo disystems = new DirectoryInfo(Statics.AppPath + "/Systems");

                DirectoryInfo dixmlsystems = new DirectoryInfo(Statics.AppPath + "/Saved Systems");

                if (!fihelp.Exists)
                {
                    FileStream fshelp = fihelp.Create();
                    fshelp.Close();

                    using (StreamWriter sw = new StreamWriter(fihelp.FullName))
                    {
                        sw.WriteLine("Did you know that the hole in the apple didn't come from the outside in?\r\nIt was eaten from the core and out to the skin\r\nAnd that's why you'll never find the worm in it\r\nBut a few bad ones won't spoil the eyes if they fall far enough from the tree\r\nThe rind is all you see, leave Eden with my seeds in your stomach\r\nWell, this disease is defined by its treatment, you people make me sick\r\nParlance of imbalanced cambia's been challenged at best\r\nAstraZeneca's just theoretical\r\nPrints of your fingers in the Rorschach jigsaw, say you saw a treasure map\r\nStraight-jacket and tie, psychiatric supply, while we tragically try to fit into a trap, but\r\nWho'd want to be human anyway? (Ay, ay, ay, ay)\r\nWho pilots all these crude machines?\r\nWhy'd you come into this world or come out that way?\r\nLike freaks of nurture, well, isn't it funny?\r\n(Well, not ha-ha funny, but y'know, funny)\r\n'Cause I doubt that you would even if you could change\r\nYou think it makes you special, but it makes you strange\r\nI doubt that you would even if you could change\r\nThe things that make you special are the things that make you strange\r\nI am the shadows cast aside by gallows, and you the red-hot sky\r\nAnd if you're believers, then why would you grieve for the dead instead of a devil that you never prayed for?\r\nYou become immune to my toxic fumes\r\nMy dose-dependent presence in your life\r\nIt's all subjective, all due respect to the collective mind, but\r\nToo weird to love, too scared to die, too alien to take you home (Ay, ay, ay, ay)\r\nHorrified at the sight of my reflection in your eyes, I don't belong there\r\nWell, it's your conclusions that make mine delusions, so I make you sane\r\nYou can thank me later\r\nWell, I doubt that you would, even if you could change\r\nYou think it makes you special, but it makes you strange\r\nI doubt that you would, even if you could change\r\nThe things that make you special are the things that make you strange\r\nWho'd want to belong to anyone? I mean, what do people even do? (Ay, ay, ay, ay)\r\nSo if you love me, let me let you go, my love, so I can be no one (Ay, ay, ay, ay)\r\nWhen Chuang-Tzu awoke, he sat up almost choking, spat out a butterfly and said, \"Five more minutes, please?\r\nYou wouldn't believe the dream I just had\r\nI mean, you were there, and you were there\r\nAnd you, and you, and you were there\"\r\n'Cause I doubt that you would, even if you could change\r\nThe things that make you special are what make you strange\r\nI doubt that you would, even if you could change\r\nThe things that make you special are the same that make you\r\nI doubt that you would even if you could change\r\nYou think it makes you special, but it makes you strange\r\nI doubt that you would even if you could change\r\nThe things that make you special are the same that make you strange");
                        sw.Close();
                    };
                    System.Diagnostics.Process.Start(fihelp.FullName);
                }

                if (!ficonfig.Exists)
                {
                    ficonfig.Create();
                    //to add
                }

                if (!disystems.Exists)
                {
                    disystems.Create();
                }

                if (!dixmlsystems.Exists)
                {
                    dixmlsystems.Create();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void TSMI_Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Statics.AppPath + "/help.txt");
        }
    }
}
