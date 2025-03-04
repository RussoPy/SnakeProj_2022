
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Linq;


namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Scale> Snake1; //list of the body of the snake
        private List<Base> saveList=new List<Base>(); // list for the save file
        private Item[] food = new Item[2]; // Array of food objects
        SoundPlayer sp = new SoundPlayer(soundLocation: @"C:\Users\galru\OneDrive\Desktop\POP - Sound Effect-YoutubeConvert.cc (1).wav");// sound for losing the game 
        private int counter; // counter for jumping object delay

        public Form1()
        {
            //initialization of the game
            Snake1 = new List<Scale>();
            InitializeComponent();
            this.KeyPreview = true;
            //Set settings to default
            new Settings();
            save_b.Enabled = false;
            load_b.Enabled = false;
            resume_b.Enabled = false;
            restart_b.Enabled = false;

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start New game
            StartGame();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Process arrow keys for snake movement, if the game is active
            if (!Settings.Puase && !Settings.GameOver)
            {
                switch (keyData)
                {
                    case Keys.Right:
                        if (Snake1[0].getDec() != 'l')
                            Snake1[0].setDec('r');
                        return true;
                    case Keys.Left:
                        if (Snake1[0].getDec() != 'r')
                            Snake1[0].setDec('l');
                        return true;
                    case Keys.Up:
                        if (Snake1[0].getDec() != 'd')
                            Snake1[0].setDec('u');
                        return true;
                    case Keys.Down:
                        if (Snake1[0].getDec() != 'u')
                            Snake1[0].setDec('d');
                        return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void StartGame()
        {
            //created objects for a new round of the game
            lblGameOver.Visible = false;
            char snake_c = 'r';
            Scale scale1 = new Scale(7, 7, true, snake_c);
            Scale scale2 = new Scale(8, 7, false, snake_c);
            Snake1.Add(scale1);
            Snake1.Add(scale2);
            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

        }
        
        private void GenerateFood()
        {
            //created neww object for the food list
            int maxXPos = pbCanvas.Size.Width / (Snake.Scale.getLength());
            int maxYPos = pbCanvas.Size.Height / (Snake.Scale.getLength());
            Random random = new Random();
            R_Item R_food = new R_Item(random.Next(0, maxXPos), random.Next(0, maxYPos));
            M_Item M_food = new M_Item(random.Next(0, maxXPos), random.Next(0, maxYPos));
            food[0] = R_food;//collection
            food[1] = M_food;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //call for a round of the game
            //while game is running change the direction of the snake when necessary
            if (!Settings.Puase && !Settings.GameOver)
            {
                int maxXPos = pbCanvas.Size.Width / (Snake.Scale.getLength());
                int maxYPos = pbCanvas.Size.Height / (Snake.Scale.getLength());
                
                
                    if (Input.KeyPressed(Keys.Right) && (Snake1[0].getDec() != 'l'))
                    {
                        Snake1[0].setDec('r');
                        //load = false;
                    }
                    else if (Input.KeyPressed(Keys.Left) && (Snake1[0].getDec() != 'r'))
                    {
                        Snake1[0].setDec('l');
                    }
                    else if (Input.KeyPressed(Keys.Up) && (Snake1[0].getDec() != 'd'))
                    {
                        Snake1[0].setDec('u');
                    }
                    else if (Input.KeyPressed(Keys.Down) && (Snake1[0].getDec() != 'u'))
                    {
                        Snake1[0].setDec('d');
                    }
                    else if (Input.KeyPressed(Keys.P))
                    {
                       Settings.Puase = true;
                       save_b.Enabled = true;
                       load_b.Enabled = true;
                       resume_b.Enabled = true;
                       restart_b.Enabled = true;
                    }


                    
                        MovePlayer();
                        if (counter % 50 == 0)
                            ((M_Item)(Object)food[1]).Jump(Snake1[0], maxXPos, maxYPos);
                        counter++; 
                
            }
            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            //draw the objects of the game
            Graphics canvas = e.Graphics;
            Brush col=null;
            if (!Settings.GameOver)
            {
                //Draw snake
                for (int i = 0; i < Snake1.Count; i++)
                {
                    //Draw snake
                    switch (Snake1[i].getColor())
                    {   case 'r':
                            col = Brushes.Red;
                            break;
                        case 'b':
                            if(i%7==0)
                            {
                                col = Brushes.Turquoise;
                            }
                            if (i % 7 == 1)
                            {
                                col = Brushes.LightBlue;
                            }
                            if (i % 7 == 2)
                            {
                                col = Brushes.Blue;
                            }
                            if (i % 7 == 3)
                            {
                                col = Brushes.LimeGreen;
                            }
                            if (i % 7 == 4)
                            {
                                col = Brushes.GreenYellow;
                            }
                            if (i % 7 == 5)
                            {
                                col = Brushes.Yellow;
                            }
                            if (i % 7 == 6)
                            {
                                col = Brushes.Red;
                            }
                            break;
                        case 'y':
                            if (i % 7 == 0)
                            {
                                col = Brushes.Turquoise;
                            }
                            if (i % 7 == 1)
                            {
                                col = Brushes.LightBlue;
                            }
                            if (i % 7 == 2)
                            {
                                col = Brushes.Blue;
                            }
                            if (i % 7 == 3)
                            {
                                col = Brushes.LimeGreen;
                            }
                            if (i % 7 == 4)
                            {
                                col = Brushes.GreenYellow;
                            }
                            if (i % 7 == 5)
                            {
                                col = Brushes.Yellow;
                            }
                            if (i % 7 == 6)
                            {
                                col = Brushes.Red;
                            }
                            break;
                    }
                    canvas.FillEllipse(col,
                        new Rectangle(Snake1[i].getX() * Base.getLength(),
                                      Snake1[i].getY() * Base.getLength(),
                                      Base.getLength(), Base.getLength()));
                }
                //Draw Food
                for (int i = 0; i < food.Length; i++)
                {
                    switch (food[i].getColor())
                    {
                        case 'b':
                            col = Brushes.Blue;
                            break;
                        case 'y':
                            col = Brushes.Yellow;
                            break;
                    }
                    canvas.FillEllipse(col,
                        new Rectangle(food[i].getX() * Base.getLength(),
                             food[i].getY() * Base.getLength(),
                             Base.getLength(), Base.getLength()));
                }
            }
            else
            {
                string gameOver = "Game over \n"+"Press Restart or Load";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {
            //move the snake body
            //check if it collieded with itself or the edge
            //check if step on fod piece
            SoundPlayer spd = new SoundPlayer(soundLocation: @"C:\Users\galru\OneDrive\Desktop\Snake\Lose sound.wav");
            Random random = new Random();
            for(int i=0; i<Snake1.Count; i++)
            {
                ((Scale)(Snake1[i])).move();
            }
            //Get maximum X and Y Pos on the board
            int maxXPos = pbCanvas.Size.Width / (Base.getLength());
            int maxYPos = pbCanvas.Size.Height / (Base.getLength());
            //Detect collission with game borders.
            if (Snake1[0].outOfBounds(maxXPos, maxYPos)) {
                Settings.GameOver = true;
                spd.Play();
                Die();
                    }
            if (Snake1.Count > 1)
            {
                for (int i = 1; i < Snake1.Count; i++)
                {
                    if (Snake1[0].collision(Snake1[i]))
                    {
                        Settings.GameOver = true;
                        spd.Play();
                        Die();
                    }
                }
            }
            //Detect collision with food piece
            if(Snake1.Count != 0)
                for (int i = 0; i < food.Length; i++)
                {
                    if (food[i].collision(Snake1[0]))
                    {
                        Eat(food[i], maxXPos, maxYPos);
                    }
                }
        }
     
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat(Item apple, int maxXPos, int maxYPos)
        {
            //add a scale for the next lists according to the correct item that has been eaten
            //create a replacment for eaten item
            //update the score
            Scale new_scale = new Scale(apple.getColor());
            Random random = new Random();
            Snake1.Add(new_scale);
            if (apple is R_Item)
            {
                apple.soundss();
                do
                {
                    food[0] = new R_Item(random.Next(0, maxXPos),
                        random.Next(0, maxYPos));
                } while (food[0].collision(food[1]) || food[0].collision(Snake1[0]));
                Settings.R_Reward();
            }
            else
            {
                apple.soundss();
                do
                {
                    food[1] = new M_Item(random.Next(0, maxXPos),
                        random.Next(0, maxYPos));
                } while (food[1].collision(food[0]) || food[1].collision(Snake1[0]));
                Settings.M_Reward();
            }
            lblScore.Text = Settings.Score.ToString();
            }

        private void Die()
        {
            //clear the snake list snd earse the score
            //a new game or a loaded one can be acivated next
            Settings.GameOver = true;
            Settings.Puase = false;
            Snake1.Clear();
            Settings.Score = 0;
            load_b.Enabled = true;
            restart_b.Enabled = true;
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {
            
        }


        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void Load_Game(object sender, MouseEventArgs e)
        {
            //clear the snake and then load a new snake and item from a file
            Snake1.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                saveList = (List<Base>)binaryFormatter.Deserialize(stream);
                pbCanvas.Invalidate();
            }
            food[0] = (R_Item)saveList[0];
            food[1] = (M_Item)saveList[1];
            for (int i = 0; i < saveList.Count; i++)
            {
                if(saveList[i] is R_Item)
                    food[i]=(R_Item)saveList[i];
                else if(saveList[i] is M_Item)
                    food[i] = (M_Item)saveList[i];
                else
                    Snake1.Add((Scale)saveList[i]);
            }
            lblGameOver.Visible = false;
            UpdateScore();
            Settings.GameOver = false;
            Settings.Puase = false;
            load_b.Enabled = false;
            restart_b.Enabled = false;
            save_b.Enabled = false;
            resume_b.Enabled = false;
            
        }

        private void Save_Game(object sender, MouseEventArgs e)
        {
            //save the objects of the game to a flie
            saveList.Add((Base)food[0]);
            saveList.Add(food[1]);
            for(int i=0;i< Snake1.Count;i++)
            {
                saveList.Add(Snake1[i]);
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, saveList);
                }
            }
            Die();
        }

        private void Resume_Game(object sender, MouseEventArgs e)
        {
            //unpuase the game
            Settings.Puase = false;
            save_b.Enabled = false;
            load_b.Enabled = false;
            resume_b.Enabled = false;
            restart_b.Enabled = false;
        }

        private void UpdateScore()
        {
            //update the score after game reload from the sanke scales
            int temp = 0;
            for (int i = 0; i < Snake1.Count; i++)
            {
                switch (Snake1[i].getColor())
                {
                    case 'b':
                        temp += 200;
                        break;
                    case 'y':
                        temp += 100;
                        break;
                }
            }
            Settings.Score = temp;
        }

        private void Restart_Game(object sender, MouseEventArgs e)
        {
            //clear the game board ans score and restart the game
            Snake1.Clear();
            Settings.Score = 0;
            Settings.GameOver = false;
            Settings.Puase= false;
            save_b.Enabled = true;
            load_b.Enabled = false;
            resume_b.Enabled = false;
            restart_b.Enabled = false;
            StartGame();
            this.BeginInvoke(new Action(() => pbCanvas.Focus()));

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void save_b_Click(object sender, EventArgs e)
        {

        }

        private void resume_b_Click(object sender, EventArgs e)
        {

        }
    }
}

