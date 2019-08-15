namespace TeamProjectwithHY
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Start_timer = new System.Windows.Forms.Timer(this.components);
            this.GameTime_Check = new System.Windows.Forms.Label();
            this.Loadtext = new System.Windows.Forms.Label();
            this.loadbar = new System.Windows.Forms.ProgressBar();
            this.loadbartimer = new System.Windows.Forms.Timer(this.components);
            this.enemy_timer = new System.Windows.Forms.Timer(this.components);
            this.Shoot_timer = new System.Windows.Forms.Timer(this.components);
            this.Hero_HP = new System.Windows.Forms.ProgressBar();
            this.Boss_HP = new System.Windows.Forms.ProgressBar();
            this.boss_HP_label = new System.Windows.Forms.Label();
            this.hero_HP_label = new System.Windows.Forms.Label();
            this.game_over_text = new System.Windows.Forms.Label();
            this.game_introduce = new System.Windows.Forms.Button();
            this.Boss_level_label = new System.Windows.Forms.Label();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.hero_p = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero_p)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("THE외계인설명서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(244, 505);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(104, 54);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "게임시작";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("THE외계인설명서", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Location = new System.Drawing.Point(246, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(305, 61);
            this.Title.TabIndex = 4;
            this.Title.Text = "드래곤볼 대전";
            // 
            // Start_timer
            // 
            this.Start_timer.Interval = 10;
            this.Start_timer.Tick += new System.EventHandler(this.timer_display);
            // 
            // GameTime_Check
            // 
            this.GameTime_Check.Enabled = false;
            this.GameTime_Check.Font = new System.Drawing.Font("THE외계인설명서", 11F);
            this.GameTime_Check.ForeColor = System.Drawing.Color.Maroon;
            this.GameTime_Check.Location = new System.Drawing.Point(12, 559);
            this.GameTime_Check.Name = "GameTime_Check";
            this.GameTime_Check.Size = new System.Drawing.Size(119, 59);
            this.GameTime_Check.TabIndex = 5;
            this.GameTime_Check.Visible = false;
            this.GameTime_Check.Click += new System.EventHandler(this.GameTime_Check_Click);
            // 
            // Loadtext
            // 
            this.Loadtext.AutoSize = true;
            this.Loadtext.Font = new System.Drawing.Font("THE외계인설명서", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loadtext.ForeColor = System.Drawing.Color.ForestGreen;
            this.Loadtext.Location = new System.Drawing.Point(336, 345);
            this.Loadtext.Name = "Loadtext";
            this.Loadtext.Size = new System.Drawing.Size(92, 34);
            this.Loadtext.TabIndex = 6;
            this.Loadtext.Text = "로딩중";
            this.Loadtext.Visible = false;
            // 
            // loadbar
            // 
            this.loadbar.Enabled = false;
            this.loadbar.Location = new System.Drawing.Point(144, 420);
            this.loadbar.Name = "loadbar";
            this.loadbar.Size = new System.Drawing.Size(483, 43);
            this.loadbar.TabIndex = 7;
            this.loadbar.Visible = false;
            // 
            // loadbartimer
            // 
            this.loadbartimer.Interval = 15;
            this.loadbartimer.Tick += new System.EventHandler(this.loadbartimer_Tick);
            // 
            // enemy_timer
            // 
            this.enemy_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Shoot_timer
            // 
            this.Shoot_timer.Interval = 18;
            this.Shoot_timer.Tick += new System.EventHandler(this.Shoot_Tick);
            // 
            // Hero_HP
            // 
            this.Hero_HP.ForeColor = System.Drawing.Color.Red;
            this.Hero_HP.Location = new System.Drawing.Point(643, 592);
            this.Hero_HP.Name = "Hero_HP";
            this.Hero_HP.Size = new System.Drawing.Size(136, 23);
            this.Hero_HP.TabIndex = 14;
            this.Hero_HP.Value = 100;
            this.Hero_HP.Visible = false;
            // 
            // Boss_HP
            // 
            this.Boss_HP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Boss_HP.ForeColor = System.Drawing.Color.Red;
            this.Boss_HP.Location = new System.Drawing.Point(170, 17);
            this.Boss_HP.Name = "Boss_HP";
            this.Boss_HP.Size = new System.Drawing.Size(467, 31);
            this.Boss_HP.TabIndex = 15;
            this.Boss_HP.Value = 100;
            this.Boss_HP.Visible = false;
            // 
            // boss_HP_label
            // 
            this.boss_HP_label.AutoSize = true;
            this.boss_HP_label.Font = new System.Drawing.Font("THE외계인설명서", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boss_HP_label.Location = new System.Drawing.Point(101, 18);
            this.boss_HP_label.Name = "boss_HP_label";
            this.boss_HP_label.Size = new System.Drawing.Size(63, 20);
            this.boss_HP_label.TabIndex = 16;
            this.boss_HP_label.Text = "보스 HP";
            this.boss_HP_label.Visible = false;
            // 
            // hero_HP_label
            // 
            this.hero_HP_label.AutoSize = true;
            this.hero_HP_label.Font = new System.Drawing.Font("THE외계인설명서", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hero_HP_label.Location = new System.Drawing.Point(560, 595);
            this.hero_HP_label.Name = "hero_HP_label";
            this.hero_HP_label.Size = new System.Drawing.Size(77, 20);
            this.hero_HP_label.TabIndex = 17;
            this.hero_HP_label.Text = "주인공 HP";
            this.hero_HP_label.Visible = false;
            // 
            // game_over_text
            // 
            this.game_over_text.AutoSize = true;
            this.game_over_text.Font = new System.Drawing.Font("THE외계인설명서", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.game_over_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.game_over_text.Location = new System.Drawing.Point(301, 212);
            this.game_over_text.Name = "game_over_text";
            this.game_over_text.Size = new System.Drawing.Size(0, 48);
            this.game_over_text.TabIndex = 18;
            this.game_over_text.Visible = false;
            // 
            // game_introduce
            // 
            this.game_introduce.Font = new System.Drawing.Font("THE외계인설명서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.game_introduce.Location = new System.Drawing.Point(452, 505);
            this.game_introduce.Name = "game_introduce";
            this.game_introduce.Size = new System.Drawing.Size(99, 54);
            this.game_introduce.TabIndex = 19;
            this.game_introduce.Text = "게임설명보기";
            this.game_introduce.UseVisualStyleBackColor = true;
            this.game_introduce.Click += new System.EventHandler(this.game_introduce_Click);
            // 
            // Boss_level_label
            // 
            this.Boss_level_label.AutoSize = true;
            this.Boss_level_label.Enabled = false;
            this.Boss_level_label.Font = new System.Drawing.Font("THE외계인설명서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Boss_level_label.ForeColor = System.Drawing.Color.Red;
            this.Boss_level_label.Location = new System.Drawing.Point(709, 30);
            this.Boss_level_label.Name = "Boss_level_label";
            this.Boss_level_label.Size = new System.Drawing.Size(0, 18);
            this.Boss_level_label.TabIndex = 20;
            this.Boss_level_label.Visible = false;
            // 
            // enemy
            // 
            this.enemy.Image = global::TeamProjectwithHY.Properties.Resources.cell;
            this.enemy.Location = new System.Drawing.Point(722, 202);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(39, 58);
            this.enemy.TabIndex = 11;
            this.enemy.TabStop = false;
            this.enemy.Visible = false;
            // 
            // hero_p
            // 
            this.hero_p.Image = global::TeamProjectwithHY.Properties.Resources.goku;
            this.hero_p.Location = new System.Drawing.Point(25, 324);
            this.hero_p.Name = "hero_p";
            this.hero_p.Size = new System.Drawing.Size(35, 55);
            this.hero_p.TabIndex = 10;
            this.hero_p.TabStop = false;
            this.hero_p.Visible = false;
            this.hero_p.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(825, 627);
            this.Controls.Add(this.Boss_level_label);
            this.Controls.Add(this.game_introduce);
            this.Controls.Add(this.game_over_text);
            this.Controls.Add(this.hero_HP_label);
            this.Controls.Add(this.boss_HP_label);
            this.Controls.Add(this.Boss_HP);
            this.Controls.Add(this.Hero_HP);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.hero_p);
            this.Controls.Add(this.loadbar);
            this.Controls.Add(this.Loadtext);
            this.Controls.Add(this.GameTime_Check);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StartButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ppp_KeyEvent);
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer Start_timer;
        private System.Windows.Forms.Label GameTime_Check;
        private System.Windows.Forms.Label Loadtext;
        private System.Windows.Forms.ProgressBar loadbar;
        private System.Windows.Forms.Timer loadbartimer;
        private System.Windows.Forms.PictureBox hero_p;
        private System.Windows.Forms.Timer enemy_timer;
        public System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Timer Shoot_timer;
        private System.Windows.Forms.ProgressBar Hero_HP;
        private System.Windows.Forms.ProgressBar Boss_HP;
        private System.Windows.Forms.Label boss_HP_label;
        private System.Windows.Forms.Label hero_HP_label;
        private System.Windows.Forms.Label game_over_text;
        private System.Windows.Forms.Button game_introduce;
        private System.Windows.Forms.Label Boss_level_label;
    }
}

