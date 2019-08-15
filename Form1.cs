using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamProjectwithHY
{

    public partial class Form1 : Form
    {
        
        public class levelcheck<T>
        {
            public T level0_flag;
            public T level1_flag;
            public T level2_flag;
            public T level3_flag;
            public void reset(T value)
            {
                this.level0_flag = value;
                this.level1_flag = value;
                this.level2_flag = value;
                this.level3_flag = value;
            }
            
        }
        levelcheck<int> l = new levelcheck<int>();
        Random ran = new Random();
        int timerCount = 0;
        int enemymove_flag = 0;
        int Playerflamecnt = 10;
        int enemysnowcnt = 30;
        PictureBox[] Playerflame;
        PictureBox[] enemysnow;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void load_game(object sender, EventArgs e)
        {
            Loadtext.Visible = true;
            loadbar.Visible = true;
            loadbar.Value = 0;
            loadbartimer.Enabled = true;
            game_introduce.Visible = false;
            game_introduce.Enabled = false;
            Cursor.Hide();
            StartButton.Visible = false;
            Title.Visible = false;
            loadbar.Enabled = true;
            StartButton.Enabled = false;
            game_over_text.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            load_game(sender, e);
            
        }

        private void timer_display(object sender, EventArgs e)
        {
            timerCount++;
            int sec = 0, min = 0, hour = 0;
            if (timerCount < 60)
            {
                sec = timerCount;
            }

            else if (timerCount < 3600)
            {
                min = timerCount / 60;
                sec = timerCount % 60;
            }
            else
            {
                hour = timerCount / 3600;
                min = (timerCount % 3600) / 60;
                sec = ((timerCount % 3600) % 60);
            }

            GameTime_Check.Text = "시간 \n" + "   " + hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "\n";
            if (min % 2 == 0)
                enemy_timer.Enabled = true;
            else
                enemy_timer.Enabled = false;
            //Refresh();
        }


        private void GameTime_Check_Click(object sender, EventArgs e)
        {

        }

        private void loadbartimer_Tick(object sender, EventArgs e)
        {
            if (loadbar.Value != loadbar.Maximum) loadbar.Value++;
            else
            {
                game_start();
            }

        }
        private void game_start()
        {
            hero_p.Location = new Point(25, 324);
            GameTime_Check.Visible = true;
            Boss_level_label.Enabled = true;
            Boss_level_label.Visible = true;
            game_introduce.Visible = false;
            game_introduce.Enabled = false;
            GameTime_Check.Enabled = true;
            loadbar.Enabled = false;
            loadbartimer.Enabled = false;
            Loadtext.Visible = false;
            loadbar.Visible = false;
            hero_p.Visible = true;
            enemy.Visible = true;
            Shoot_timer.Enabled = true;
            Boss_HP.Visible = true;
            Hero_HP.Visible = true;
            l.reset(0);
            Boss_HP.Value = 100;
            Hero_HP.Value = 100;
            Start_timer.Start();
            boss_HP_label.Visible = true;
            hero_HP_label.Visible = true;
            Playerflamecnt = 10;
            enemysnowcnt = 30;
            int enemy_x = ran.Next(550, 680);
            int enemy_y = ran.Next(20, 530);
            enemy.Location = new Point(enemy_x, enemy_y);
            Playerflame = new PictureBox[Playerflamecnt];
            enemysnow = new PictureBox[enemysnowcnt];
            for (int i = 0; i < Playerflamecnt; i++)
            {
                Playerflame[i] = new PictureBox();
                Playerflame[i].Image = TeamProjectwithHY.Properties.Resources.gokufire1;
                Playerflame[i].Location = new System.Drawing.Point(Width, Height);
                Playerflame[i].Name = "Playerflament" + i;
                Playerflame[i].Size = new System.Drawing.Size(20, 20);
                Playerflame[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                Playerflame[i].Visible = false;
                Controls.Add(Playerflame[i]);
            }
            for (int i = 0; i < enemysnowcnt; i++)
            {
                enemysnow[i] = new PictureBox();
                enemysnow[i].Image = TeamProjectwithHY.Properties.Resources.gokufire1;
                enemysnow[i].Location = new System.Drawing.Point(Width, Height);
                enemysnow[i].Name = "enemysnownt" + i;
                enemysnow[i].Size = new System.Drawing.Size(20, 20);
                enemysnow[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                enemysnow[i].Visible = false;
                Controls.Add(enemysnow[i]);
            }

        }
        private void flameMove()
        {
            for (int i = 0; i < Playerflamecnt; i++)
            {
                if (Playerflame[i].Visible == false)
                    continue;
                int straight = Playerflame[i].Location.X + 13;
                if (straight>800)
                    Playerflame[i].Visible = false;
                else
                {
                    Point MoveMissile = new Point(straight,Playerflame[i].Location.Y);
                    Playerflame[i].Location = MoveMissile;
                }
                if (enemy.Bounds.IntersectsWith(Playerflame[i].Bounds))
                {

                    Playerflame[i].Visible = false;
                    if (Boss_HP.Value>Boss_HP.Minimum) 
                        Boss_HP.Value -= 4;
                    if (Boss_HP.Value<=Boss_HP.Minimum)
                    {
                        game_over();
                    }
                }
            }
        }

        
        private void snowMove()
        {
            
            for (int i = 0; i < enemysnowcnt; i++)
            {
                int straight = enemysnow[i].Location.X - 13;
                Point left_cross = new Point(enemysnow[i].Location.X - 13, enemysnow[i].Location.Y - 3);
                Point right_cross = new Point(enemysnow[i].Location.X - 13, enemysnow[i].Location.Y + 3);
                if (straight <10||left_cross.X<10||right_cross.X<10)
                    enemysnow[i].Visible = false;
                else
                {
                    Point MoveMissile=new Point(straight,enemysnow[i].Location.Y);
                    if (i%3==0)
                        MoveMissile = left_cross;
                    else if (i%4==0)
                    {
                        MoveMissile = right_cross;
                    }
                    enemysnow[i].Location = MoveMissile;
                }
                if (hero_p.Bounds.IntersectsWith(enemysnow[i].Bounds))
                {
                    enemysnow[i].Visible = false;
                    if (Hero_HP.Value > Hero_HP.Minimum)
                        Hero_HP.Value -= 4;
                    if (Hero_HP.Value <= Hero_HP.Minimum)
                    {
                        game_over();
                    }
                }
            }
        }
        private void game_over()
        {
            snow_flameStop();
            Boss_level_label.Visible = false;
            Boss_level_label.Enabled = false;
            timerCount = 0;
            game_over_text.Visible = true;
            if (Boss_HP.Value<=0)
                game_over_text.Text ="승리\n" + GameTime_Check.Text.ToString();
            else
                game_over_text.Text = "패배!!\n" + GameTime_Check.Text.ToString();
            boss_HP_label.Visible = false;
            hero_HP_label.Visible = false;
            hero_p.Visible = false;
            enemy.Visible = false;
            Shoot_timer.Enabled = false;
            GameTime_Check.Visible = false;
            Boss_HP.Visible = false;
            Hero_HP.Visible = false;
            Start_timer.Enabled = false;
            StartButton.Enabled = true;
            StartButton.Visible = true;
            StartButton.Text = "재도전";
            Cursor.Show();
        }
        private void level_change(ref levelcheck<int> l)
        {
            
            if (Boss_HP.Value == 100 && l.level0_flag == 0)
            {
                enemy.Image = TeamProjectwithHY.Properties.Resources.cell;
                enemy.Size = new System.Drawing.Size(39, 58);
                Boss_level_label.Text = "보스레벨 1";
                enemy_timer.Interval = 100;
                enemysnowcnt = 15;
                l.level0_flag = 1;
            }
            else if (Boss_HP.Value <= 80 && l.level1_flag == 0)
            {
                Boss_level_label.Text = "보스레벨 2";
                enemy.Image= TeamProjectwithHY.Properties.Resources.cell602;
                enemy.Size = new System.Drawing.Size(49, 77);
                enemysnowcnt = 25;
                enemy_timer.Interval = 70;
                l.level1_flag = 1;
            }
            else if (Boss_HP.Value <= 40 && l.level2_flag == 0)
            {
                Boss_level_label.Text = "보스레벨 3";
                enemy.Image = TeamProjectwithHY.Properties.Resources.cell40;
                enemy.Size = new System.Drawing.Size(60, 81);
                enemysnowcnt = 25;
                enemy_timer.Interval = 50;
                l.level2_flag = 1;
            }
            else if (Boss_HP.Value <= 20 && l.level3_flag == 0)
            {
                Boss_level_label.Text = "보스레벨 4";
                enemy.Image = TeamProjectwithHY.Properties.Resources.celllast;
                enemy.Size = new System.Drawing.Size(72, 103);
                enemysnowcnt = 30;
                enemy_timer.Interval = 30;
                l.level3_flag = 1;
            }
        }
        private void Shoot_Tick(object sender, EventArgs e)
        {
            flameMove();
            snowStart();
            snowMove();
            level_change(ref l);
        }
        private void firemotion()
        {
            hero_p.Image = TeamProjectwithHY.Properties.Resources.gokufiremotion;
        }
        private void idlemotion()
        {
            hero_p.Image = TeamProjectwithHY.Properties.Resources.goku;
        }
        private void flameStart()
        {
            for (int i = 0; i < Playerflamecnt; i++)
            {
                if (Playerflame[i].Visible == true)
                    continue;
                Playerflame[i].Location = hero_p.Location;
                Playerflame[i].Visible = true;
                break;
            }
        }
        private void snowStart()
        {

            for (int i = 0; i < enemysnowcnt; i++)
            {
                if (enemysnow[i].Visible == true)
                    continue;
                enemysnow[i].Location = enemy.Location;
                enemysnow[i].Visible = true;
                break;
            }
        }
        private void snow_flameStop()
        {
            for (int i=0;i<enemysnowcnt;i++)
            {
                if (enemysnow[i].Visible == true)
                    enemysnow[i].Visible = false;
            }

            for (int i = 0; i <Playerflamecnt; i++)
            {
                if (Playerflame[i].Visible == true)
                    Playerflame[i].Visible = false;
            }
        }
        public void ppp_KeyEvent(object sender, KeyEventArgs e)
        {
            int x = hero_p.Location.X;
            int y = hero_p.Location.Y;
            if (e.KeyCode == Keys.Right)
            {
                idlemotion();
                hero_p.Location = new Point(x += 20, y);
            }
            if (e.KeyCode == Keys.Left)
            {
                idlemotion();
                hero_p.Location = new Point(x -= 20, y);
            }
            if (e.KeyCode == Keys.Up)
            {
                idlemotion();
                hero_p.Location = new Point(x, y -= 20);
            }
            if (e.KeyCode == Keys.Down)
            {
                idlemotion();
                hero_p.Location = new Point(x, y += 20);
            }
            if (e.KeyCode == Keys.A)
            {
                try
                {
                    firemotion();
                    flameStart();
                    
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("게임시작 전입니다.");
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = enemy.Location.X;
            int y = enemy.Location.Y;
            if (enemymove_flag == 0)
            {
                enemy.Location = new Point(x, y+=10);
                if (y > 450)
                    enemymove_flag = 1;
            }
            else if (enemymove_flag == 1)
            {
                enemy.Location = new Point(x, y-=10);
                if (y < 20)
                    enemymove_flag = 0;
            }
        }

        private void game_introduce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("주인공 (손오공)이 적(셀) 을 죽이면 되는 게임입니다.\n"
                            + "미사일 발사는 A 버튼 이며 적 HP가 깎일수록 난이도는\n" +
                            "상승합니다.");
        }
    }
}
