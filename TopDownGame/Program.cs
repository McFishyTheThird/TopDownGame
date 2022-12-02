using Raylib_cs;
Raylib.InitWindow(800, 600, "Williams Crinchtopia");
Raylib.SetTargetFPS(100);
Raylib.InitAudioDevice();
Texture2D avatarImage = Raylib.LoadTexture("ActualTrueDoomguy.png");
Texture2D bigDaddyDoomguy = Raylib.LoadTexture("BigBoss.png");
Texture2D avatarImagePowered = Raylib.LoadTexture("DoomPowerup2.png");
Texture2D avatarImagePowered2 = Raylib.LoadTexture("DoomPowerup.png");
Texture2D backGround1 = Raylib.LoadTexture("Background1.png");
Texture2D backGround2 = Raylib.LoadTexture("Background2.png");
Texture2D backGround3 = Raylib.LoadTexture("Background3.png");
Texture2D playerProjectile = Raylib.LoadTexture("PlayerProjectile.png");
Texture2D bossProjectile = Raylib.LoadTexture("BossProjectile.png");
Texture2D bossProjectileShotgun = Raylib.LoadTexture("BossShotgunAttack.png");
Texture2D gameOver = Raylib.LoadTexture("GameOver.png");
Texture2D startScreen = Raylib.LoadTexture("Thetruedoomsotry.png");
int V = 0;
int E = 0;
int B = 0;
int plusH = 0;
int hpExtra = 0;
Color pantone448C = new Color(74, 65, 42, 255);
Color arsenik = new Color(59, 68, 75, 255);
Color oxBlood = new Color(74, 4, 4, 255);
int points = 69;
Random generator = new Random ();
int damage = generator.Next(1,3);
Rectangle health = new Rectangle (10, 10, 300, 30);
Rectangle healthLost = new Rectangle (10, 10, 300, 30);
Rectangle miniBossHealth = new Rectangle (480, 10, 300, 10);
Rectangle miniBossHealthLost = new Rectangle (480, 10, 300, 10);
Rectangle bossHealthPhase1 = new Rectangle (630, 10, 150, 10);
Rectangle bossHealthLostPhase1 = new Rectangle (630, 10, 150, 10);
Rectangle bossHealthPhase2 = new Rectangle (475, 10, 150, 10);
Rectangle bossHealthLostPhase2 = new Rectangle (475, 10, 150, 10);
Rectangle bossHealthPhaseBezos = new Rectangle (320, 10, 150, 10);
Rectangle bossHealthLostPhaseBezos = new Rectangle (320, 10, 150, 10);
Rectangle bossHealthPhaseBezosChrist = new Rectangle (320, 10, 465, 10);
Rectangle bossHealthLostPhaseBezosChrist = new Rectangle (320, 10, 465, 10);
Rectangle stamina = new Rectangle (490, 575, 300, 20);
Texture2D miniBossProjectile = Raylib.LoadTexture("MiniBossProjectile.png");
Rectangle staminaLost = new Rectangle (490, 575, 300, 20);
Rectangle armorBar = new Rectangle (10, 50, 200, 20);
Rectangle armorLost = new Rectangle (10, 50, 200, 20);
Texture2D powerUp = Raylib.LoadTexture("Power up.png");
Texture2D veggiePack = Raylib.LoadTexture("veggiePack.png");
Texture2D armorPack = Raylib.LoadTexture("ArmorPack.png");
Texture2D energyPack = Raylib.LoadTexture("EnergyBattery.png");
Texture2D enemy1 = Raylib.LoadTexture("Monster1.png");
Texture2D enemy2 = Raylib.LoadTexture("Monster2.png");
Texture2D miniBoss = Raylib.LoadTexture("Monster3.png");
Texture2D bossNuk = Raylib.LoadTexture("BossProjectile2.png");
Texture2D bossAmazonClosed = Raylib.LoadTexture("BossProjectile2Box.png");
Texture2D bossAmazonOpen = Raylib.LoadTexture("BossProjectile2Box2.png");
Texture2D bossLaser = Raylib.LoadTexture("Laser.png");
Texture2D bossLaserWarning = Raylib.LoadTexture("WarningLaser.png");
Rectangle playerRect = new Rectangle(370, 270, avatarImage.width, avatarImage.height);
List<Rectangle> enemies = new List<Rectangle>();
List<Rectangle> miniBossProjectiles = new List<Rectangle>();
List<Rectangle> bossProjectiles = new List<Rectangle>();
List<Rectangle> bossNuksBox = new List<Rectangle>();
List<Rectangle> bossNuks = new List<Rectangle>();
List<float> deleteTexts = new List<float>();
List<string> text = new List<string>();
List<int> textPlace = new List<int>();
Music ripAndTear = Raylib.LoadMusicStream("Rip_Tear.mp3");
Music hellOnEarth = Raylib.LoadMusicStream("Hell On Earth.mp3");
Music bigDaddyDoomguyTheme = Raylib.LoadMusicStream("Cultist Base.mp3");
Music bigAngryDoomguyTheme = Raylib.LoadMusicStream("BFG Division.mp3");
Music bigDaddyBezosTheme = Raylib.LoadMusicStream("Metal Hell.mp3");
Music jesusBezosThemeSong = Raylib.LoadMusicStream("The Only Thing They Fear Is You.mp3");
float totalDamage = 0;
int X = generator.Next(50, 801);
int Y = generator.Next(50, 601);
text.Add("[Sensei yugmooD has joined the game]");
text.Add("[Sensei yugmooD has left the game]");
text.Add("[Big Daddy Doomguy has joined the game]");
text.Add("[Big Daddy Doomguy] *Gets angy*");
text.Add("[Jeff Bezos has joined the game]");
text.Add("[Jeff Bezos] *Laughs menacingly*");
text.Add("[Jeff Bezos is evolving!]");
text.Add("[Jeff Bezos has evolved into Bezos Christ Our Lord And Saviour!]");
text.Add("[Bezos Christ Our Lord And Saviour has left the game]");
for (int i = 0; i < text.Count; i++)
{
    deleteTexts.Add(0);
}
for (int i = 0; i < text.Count; i++)
{
    textPlace.Add(475);
}
for (int i = 0; i < 4; i++)
{
    enemies.Add(new Rectangle(X, Y, enemy1.width, enemy1.height));
    X = generator.Next(50, 801);
    Y = generator.Next(50, 601);
}
for (int i = 0; i < 3; i++)
{
    bossProjectiles.Add(new Rectangle(-1, Y, bossProjectile.width, bossProjectile.height));
    Y = generator.Next(50, 601);
}
for (int i = 0; i < 3; i++)
{
    X = generator.Next(10, 751-bossNuk.width);
    bossNuksBox.Add(new Rectangle(X, 0-bossAmazonClosed.width, bossNuk.width, bossNuk.height));
}
for (int i = 0; i < 3; i++)
{
    bossNuks.Add(new Rectangle(bossNuksBox[i].x, -1, bossNuk.width, bossNuk.height));
}
Texture2D goldDude = Raylib.LoadTexture("GoldenDuumguyB).png");
enemies.Add(new Rectangle(X, Y, enemy1.width, enemy1.height));
Rectangle goldDudePlace = new Rectangle(X, Y, goldDude.width, goldDude.height);
Rectangle miniBossProjectilePlace = new Rectangle(X, 601, miniBossProjectile.width, miniBossProjectile.height);
Rectangle miniBossPlace = new Rectangle(230, 270, miniBoss.width, miniBoss.height);
Rectangle veggiePackPlace = new Rectangle(X, Y, veggiePack.width, veggiePack.height);
Rectangle armorPackPlace = new Rectangle(X, Y, armorPack.width, armorPack.height);
Rectangle energyPackPlace = new Rectangle(X, Y, energyPack.width, energyPack.height);
Rectangle playerProjectilePlace = new Rectangle(0, 0, playerProjectile.width, playerProjectile.height);
Rectangle enemy2Place = new Rectangle(X, Y, 50, 50);
Rectangle bossLaserPlace = new Rectangle(800-bossLaser.width, 0, bossLaser.width, bossLaser.height);
Rectangle bigDaddyDoomguyPlace = new Rectangle(-805, 0, bigDaddyDoomguy.width, bigDaddyDoomguy.height);
int powerPack = generator.Next(1, 201);
int healthyPack = generator.Next(1, 201);
int stronkPack = generator.Next(1, 201);
int backGroundSelect = generator.Next(1,4);
X = generator.Next(50, 801);
Y = generator.Next(50, 601);
Rectangle powerUpPlace = new Rectangle(X, Y, 30, 30);
string mode = "Normal";
float speed = 3;
float projectileSpeed = 0.75f;
float megaSpeeeeeeed = 3.1f;
float e2Speed = 1;
float energySpawn = 0;
float veggieSpawn = 0;
float armorSpawn = 0;
float bossReload = 0; 
float bossNukSpawn = 0;
float bossLaserSpawn = 0;
string currentScene = "start"; //start, game, end, victory
while(Raylib.WindowShouldClose() == false)
{
    //Scene Game
    if (currentScene == "game")
    {
        //Miniboss
        if (points > 34)
        {
            Raylib.StopMusicStream(ripAndTear);
        }
        if (points < 69 && points > 34)
        {
            if (playerRect.y > 200)
            {
                playerRect.y = 0;
            }
            armorBar.width = 0;
            Raylib.PlayMusicStream(hellOnEarth);
            Raylib.UpdateMusicStream(hellOnEarth);
            if(miniBossProjectilePlace.y == 601)
            {
                X = generator.Next(0, 401); 
                miniBossProjectilePlace.x = X;
                miniBossProjectilePlace.y --;
            }
            if(miniBossProjectilePlace.y < 0)
            {
                miniBossProjectilePlace.y = 601;
                X = generator.Next(0, 401);
                miniBossProjectilePlace.x = X;
            }
            if (miniBossProjectilePlace.y < 601)
            {
                miniBossProjectilePlace.y -= 3;
            }
            if(Raylib.CheckCollisionRecs(playerRect, miniBossProjectilePlace))
            {
                health.width -= 3;
            }
            if(Raylib.CheckCollisionRecs(playerProjectilePlace, miniBossPlace))
            {
                
                miniBossHealth.width -= 3 * totalDamage;
                playerProjectilePlace.y = playerRect.y;
                playerProjectilePlace.x = playerRect.x;
                totalDamage = 0;
            }
            if (Raylib.CheckCollisionRecs(playerRect, miniBossPlace))
            {
                health.width -= 9999;
            }
            if (miniBossHealth.width < 0)
            {
                points += 34;
            }
        }
        //Bossfight
        if (points > 68)
        {
            if (hpExtra == 0)
            {
                health.width = 300;
                hpExtra++;
            }
            if (bigDaddyDoomguyPlace.x == -200)
            {
                Raylib.StopMusicStream(hellOnEarth);
                for (int i = 0; i < bossProjectiles.Count; i++)
                {
                    Rectangle rect = bossProjectiles[i];
                    bossReload += Raylib.GetFrameTime();
                    if (bossReload > 1.66f && E != 5)
                    {  
                        if(rect.x == -1)
                        {
                            Y = generator.Next(0, 551); 
                            rect.y = Y;
                            rect.x ++;
                            bossReload = 0;
                        }
                    }
                    if(rect.x > 800 || E == 5)
                    {
                        rect.x = -1;
                        Y = generator.Next(0,551);
                        rect.y = Y;
                    }
                    if (rect.x > -1 && E != 5)
                    {
                        rect.x += 5;
                    }
                    if(Raylib.CheckCollisionRecs(playerRect, rect) && E != 5)
                    {
                        health.width -= 2;
                    }
                    bossProjectiles[i] = rect;
                }
            }
            if (bossHealthPhase1.width > 0 && E == 0)
            {
                Raylib.PlayMusicStream(bigDaddyDoomguyTheme);
                Raylib.UpdateMusicStream(bigDaddyDoomguyTheme);
            }
            if (bossHealthPhase1.width < 75 && plusH == 0)
            {
                health.width += 300;
                if (health.width > healthLost.width)
                {
                    health.width = healthLost.width;
                }
                plusH ++;
            }
            if (bossHealthPhase1.width < 0 && E == 0)
            {
                E++;
            }
            if (bossHealthPhase2.width > 0 && E == 2)
            {
                Raylib.PlayMusicStream(bigAngryDoomguyTheme);
                Raylib.UpdateMusicStream(bigAngryDoomguyTheme);
            }
            if (bossHealthPhase2.width < 75 && plusH == 1)
            {
                health.width += 300;
                if (health.width > healthLost.width)
                {
                    health.width = healthLost.width;
                }
                plusH ++;
            }
            if (bossHealthPhase2.width < 0 && E == 2)
            {
                E++;
            }
            if (bossHealthPhaseBezos.width > 0 && E == 4)
            {
                Raylib.PlayMusicStream(bigDaddyBezosTheme);
                Raylib.UpdateMusicStream(bigDaddyBezosTheme);
            }
            if (bossHealthPhaseBezos.width < 75 && plusH == 2)
            {
                health.width += 300;
                if (health.width > healthLost.width)
                {
                    health.width = healthLost.width;
                }
                plusH ++;
            }
            if (bossHealthPhaseBezos.width < 0 && E == 4)
            {
                E++;
            }
            if(bossHealthPhaseBezos.width < 0 && E == 7)
            {
                Raylib.PlayMusicStream(jesusBezosThemeSong);
                Raylib.UpdateMusicStream(jesusBezosThemeSong);
            }
            if (Raylib.CheckCollisionRecs(playerProjectilePlace, bigDaddyDoomguyPlace))
            {
                if (E == 0)
                {
                    bossHealthPhase1.width -= 1*totalDamage;
                    playerProjectilePlace.y = playerRect.y;
                    playerProjectilePlace.x = playerRect.x;
                    totalDamage = 0;
                }
                if ( E == 2)
                {
                    bossHealthPhase2.width -= 1*totalDamage;
                    playerProjectilePlace.y = playerRect.y;
                    playerProjectilePlace.x = playerRect.x;
                    totalDamage = 0;
                }
                if (E == 4)
                {
                    bossHealthPhaseBezos.width -= 1*totalDamage;
                    playerProjectilePlace.y = playerRect.y;
                    playerProjectilePlace.x = playerRect.x;
                    totalDamage = 0;

                }
                if (E == 7)
                {
                    bossHealthPhaseBezosChrist.width -= 2*totalDamage;
                    playerProjectilePlace.y = playerRect.y;
                    playerProjectilePlace.x = playerRect.x;
                    totalDamage = 0;
                }
            }
            //no touch personal space
            if (Raylib.CheckCollisionRecs(playerRect, bigDaddyDoomguyPlace))
            {
                health.width -= 9999;
            }
            //Second phase laser
            if (bossHealthPhase1.width < 0  && E != 5)
            {
                bossLaserSpawn += Raylib.GetFrameTime();
                if (Raylib.CheckCollisionRecs(playerRect, bossLaserPlace) && bossLaserSpawn > 3)
                {
                    health.width -= 3;
                }
                if (bossLaserSpawn > 1 && bossLaserSpawn < 2)
                {
                    bossLaserPlace.x = playerRect.x;
                }
            }
            //Jeff Bezos Amazon nukes
            if (bossHealthPhase2.width < 0  && E != 5)
            {
                for(int i = 0; i < bossNuksBox.Count; i++)
                {
                    Rectangle rect = bossNuksBox[i];
                    if (rect.y < 1)
                    {
                        rect.y++;
                    }
                    bossNuksBox[i] = rect;
                    for(int k = 0; k < bossNuks.Count; k++)
                    {
                        Rectangle rect2 = bossNuks[i];
                        if (rect.y == 1 && B == 0)
                        {
                            rect2.y++;
                            B++;
                        }
                        if (rect2.y > -1 && rect2.y < 600-bossNuk.width)
                        {
                            rect2.y += 0.75f;
                        }
                        bossNuks[i] = rect2;
                    }
                }

            }
            if (bossLaserSpawn > 4 || E == 5)
            {
                bossLaserSpawn = 0;
            }
            if (bossHealthPhaseBezosChrist.width < 0)
            {
                currentScene = "victory";
            }
        }
        //Powerup Theme Song
        Raylib.UpdateMusicStream(ripAndTear);
        if (mode == "Powered")
        {
            playerRect.width = avatarImagePowered.width;
            playerRect.height = avatarImagePowered.height;
            if(points < 35)
            {
                Raylib.PlayMusicStream(ripAndTear);
            }
        }
        else
        {
            playerRect.width = avatarImage.width;
            playerRect.height = avatarImage.height;
            Raylib.StopMusicStream(ripAndTear);
        }
        //Sprint
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
        {
            if (stamina.width > 0)
            {
                speed = 5;
                megaSpeeeeeeed = 5.1f;
            }
            else
            {
                speed = 3;
                megaSpeeeeeeed = 3.1f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                stamina.width -= 1;
            }
            if (stamina.width < 0)
            {
                stamina.width = 0;
            }
        }
        else
        {
            speed = 3;
            megaSpeeeeeeed = 3.1f;
            stamina.width += 0.1f;
            if (stamina.width > staminaLost.width)
            {
                stamina.width = staminaLost.width;
            }
        }
        //No Powerup/Powerup width
        if (mode == "Normal")
        {
            if (playerRect.x < 0)
            {
                playerRect.x = 0;
            }
            if (playerRect.y < 0)
            {
                playerRect.y = 0;
            }
            if (playerRect.x > 800-avatarImage.width)
            {
                playerRect.x = 800-avatarImage.width;
            }
            if (playerRect.y > 600-avatarImage.height)
            {
                playerRect.y = 600-avatarImage.height;
            }
        }
        else if (mode == "Powered")
        {
            if (playerRect.x < 0)
            {
                playerRect.x = 0;
            }
            if (playerRect.y < 0)
            {
                playerRect.y = 0;
            }
            if (playerRect.x > 800-avatarImagePowered.width)
            {
                playerRect.x = 800-avatarImagePowered.width;
            }
            if (playerRect.y > 600-avatarImagePowered.height)
            {
                playerRect.y = 600-avatarImagePowered.height;
            }
        }
        //Enemies(and other things that have to do with them)
        if (points < 35)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Rectangle rect = enemies[i];
                float eSpeed = 1.5f;
                if(points > 19)
                {
                    eSpeed = 2f;
                }
                //Projectiles              
                if (mode == "Powered")
                {
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_K) || Raylib.IsKeyPressed(KeyboardKey.KEY_L) || Raylib.IsKeyPressed(KeyboardKey.KEY_J) || Raylib.IsKeyPressed(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                    if(Raylib.IsKeyReleased(KeyboardKey.KEY_K) || Raylib.IsKeyReleased(KeyboardKey.KEY_L) || Raylib.IsKeyReleased(KeyboardKey.KEY_J) || Raylib.IsKeyReleased(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                    if(playerProjectilePlace.x < 0 || playerProjectilePlace.x > 800 || playerProjectilePlace.y < 0 || playerProjectilePlace.y > 600)
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                    if(Raylib.IsKeyDown(KeyboardKey.KEY_K))
                    {
                        playerProjectilePlace.y += projectileSpeed;

                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y -= projectileSpeed;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_J))
                    {
                        playerProjectilePlace.x -= projectileSpeed;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_L))
                    {
                        playerProjectilePlace.x += projectileSpeed;
                    }
                    //if you hit an enemy
                    if (Raylib.CheckCollisionRecs(playerProjectilePlace, rect))
                    {
                        X = generator.Next(1, 771);
                        Y = generator.Next(1, 571);
                        if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                        {
                            X = generator.Next(1, 801);
                            Y = generator.Next(1, 601);  
                        }
                        rect.y = Y;
                        rect.x = X;
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                }
                //Enemy 1 AI
                if (playerRect.x < rect.x)
                {
                    rect.x -= eSpeed;
                }
                if (playerRect.x > rect.x)
                {
                    rect.x += eSpeed;
                }
                if (playerRect.y < rect.y)
                {
                    rect.y -= eSpeed;
                }
                if (playerRect.y > rect.y)
                {
                    rect.y += eSpeed;
                }
                if (points < 35)
                {
                    if  (Raylib.CheckCollisionRecs(playerRect, rect))
                    {
                        if (mode == "Normal")
                        {
                            health.width -= 5;
                            X = generator.Next(1, 771);
                            Y = generator.Next(1, 571);
                            if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                            {
                                X = generator.Next(1, 801);
                                Y = generator.Next(1, 601);  
                            }
                            rect.y = Y;
                            rect.x = X;
                        }
                        else if (mode == "Powered")
                        { 
                            if(armorBar.width > 99)
                            {
                                health.width -= 1;
                                armorBar.width -= 10;
                            }
                            if(armorBar.width < 100)
                            {
                                health.width -= 2;
                                armorBar.width -= 15;
                            }
                            if (health.width > healthLost.width)
                            {
                                health.width = healthLost.width;
                            }
                            X = generator.Next(1, 771);
                            Y = generator.Next(1, 571);
                            if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                            {
                                X = generator.Next(1, 801);
                                Y = generator.Next(1, 601);  
                            }
                            rect.y = Y;
                            rect.x = X;
                            if (armorBar.width == 0 || armorBar.width < 0)
                            {
                                mode = "Normal";
                                playerRect.height = avatarImage.height;
                                playerRect.width = avatarImage.width;
                            }
                        }
                    }
                }
                //Golden Dude
                if (Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
                {
                    int pointIncrease = generator.Next(1, 3 );
                    points += pointIncrease;
                    X = generator.Next(1, 771);
                    Y = generator.Next(1, 571);
                    if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
                    {
                    X = generator.Next(1, 801);
                    Y = generator.Next(1, 601);  
                    }
                    goldDudePlace.y = Y;
                    goldDudePlace.x = X;
                }
                enemies[i] = rect;
            }
        }
            //Golden Dude AI
            if (playerRect.x < goldDudePlace.x)
            {
                goldDudePlace.x += megaSpeeeeeeed;
            }
            if (playerRect.x > goldDudePlace.x)
            {
                goldDudePlace.x -= megaSpeeeeeeed;
            }
            if (playerRect.y < goldDudePlace.y)
            {
                goldDudePlace.y += megaSpeeeeeeed;
            }
            if (playerRect.y > goldDudePlace.y)
            {
                goldDudePlace.y -= megaSpeeeeeeed;
            }
            if (goldDudePlace.x < 0)
            {
                goldDudePlace.x = 0;
            }
            if (goldDudePlace.y < 0)
            {
                goldDudePlace.y = 0;
            }
            if (goldDudePlace.x > 800 - goldDude.width)
            {
                goldDudePlace.x = 800 - goldDude.width;
            }
            if (goldDudePlace.y > 600 - goldDude.height)
            {
                goldDudePlace.y = 600 - goldDude.height;
            }
        //Movement
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            playerRect.x += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            playerRect.x -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            playerRect.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            playerRect.y += speed;
        }
        //Powerup
        if (mode == "Normal")
        {
            if (Raylib.CheckCollisionRecs(playerRect, powerUpPlace))
            {
                mode = "Powered";
                X = generator.Next(50, 771);
                Y = generator.Next(50, 571);
                powerUpPlace.x = X;
                powerUpPlace.y = Y;
                armorBar.width = 200;
            }
        }
        //Projectile for miniboss and boss(because i programed badly)
        if (points > 34)
        {
                mode = "Powered";
                projectileSpeed = 4;
                    if(playerProjectilePlace.x < 10 || playerProjectilePlace.x > 790 || playerProjectilePlace.y <   10 || playerProjectilePlace.y > 590)
                    {
                        totalDamage = 0;
                    }
                    if(Raylib.IsKeyReleased(KeyboardKey.KEY_K) || Raylib.IsKeyReleased(KeyboardKey.KEY_L) || Raylib.IsKeyReleased(KeyboardKey.KEY_J) || Raylib.IsKeyReleased(KeyboardKey.KEY_I))
                    {
                        totalDamage = 0;
                    }
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_K) || Raylib.IsKeyPressed(KeyboardKey.KEY_L) || Raylib.IsKeyPressed(KeyboardKey.KEY_J) || Raylib.IsKeyPressed(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                    if(Raylib.IsKeyReleased(KeyboardKey.KEY_K) || Raylib.IsKeyReleased(KeyboardKey.KEY_L) || Raylib.IsKeyReleased(KeyboardKey.KEY_J) || Raylib.IsKeyReleased(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                        if (points > 49)
                        {
                            totalDamage = 0;
                        }
                    }
                    if(Raylib.IsKeyDown(KeyboardKey.KEY_K))
                    {
                        playerProjectilePlace.y += projectileSpeed;
                        totalDamage += 0.05f;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_I))
                    {
                        playerProjectilePlace.y -= projectileSpeed;
                        totalDamage += 0.05f;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_J))
                    {
                        playerProjectilePlace.x -= projectileSpeed;
                        totalDamage += 0.5f;
                    }
                    else if(Raylib.IsKeyDown(KeyboardKey.KEY_L))
                    {
                        playerProjectilePlace.x += projectileSpeed;
                        totalDamage += 0.05f;
                    }
                    if(playerProjectilePlace.x < 0 || playerProjectilePlace.x > 800 || playerProjectilePlace.y < 0 || playerProjectilePlace.y > 600)
                    {
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                }
                //other powerups(energy/health/armor)
                energySpawn += Raylib.GetFrameTime();
                if(energySpawn > 9)
                {
                    if (Raylib.CheckCollisionRecs(playerRect, energyPackPlace)  && points < 69)
                    {
                        if(points < 35)
                        {
                            X = generator.Next(50, 750);
                            Y = generator.Next(50, 550);
                            energyPackPlace.x = X;
                            energyPackPlace.y = Y;
                        }
                        stamina.width += 100;
                        if (stamina.width > staminaLost.width)
                        {
                            stamina.width = staminaLost.width;
                        }
                        energySpawn = 0;
                    }
                }
                //Health Pack
                veggieSpawn += Raylib.GetFrameTime();
                if(veggieSpawn > 4)
                {
                    if(points > 34 && points < 69 && V == 0)
                    {
                        X = generator.Next(0, 750);
                        Y = generator.Next(40, 100);
                        veggiePackPlace.x = X;
                        veggiePackPlace.y = Y;
                        V++;
                    }
                    if(points < 69)
                    {
                        if (Raylib.CheckCollisionRecs(playerRect, veggiePackPlace))
                        {
                            if(points < 35)
                            {
                                X = generator.Next(50, 750);
                                Y = generator.Next(50, 550);
                                veggiePackPlace.x = X;
                                veggiePackPlace.y = Y;
                            }
                            if(points > 34 && points < 69)
                            {
                                X = generator.Next(50, 100);
                                Y = generator.Next(50, 100);
                                veggiePackPlace.x = X;
                                veggiePackPlace.y = Y;
                            }
                            health.width += 50;
                            if (health.width > healthLost.width)
                            {
                                health.width = healthLost.width;
                            }
                            veggieSpawn = 0;
                        }
                    }
                }
                //Armor Pack
                if (points < 35)
                {
                    if(mode == "Powered")
                    {
                        armorSpawn += Raylib.GetFrameTime();
                        if(armorSpawn > 2)
                        {
                            if (Raylib.CheckCollisionRecs(playerRect, armorPackPlace)  && points < 69)
                            {
                                if(points < 35)
                                {
                                    X = generator.Next(50, 750);
                                    Y = generator.Next(50, 550);
                                    armorPackPlace.x = X;
                                    armorPackPlace.y = Y;
                                }
                                armorBar.width += 50;
                                if (armorBar.width > armorLost.width)
                                {
                                    armorBar.width = armorLost.width;
                                }
                                armorSpawn = 0;
                            }
                        }
                    }
                }
        //Second enemy joins the battle
        if (points > 19 && points < 35)
        {
            if (playerRect.x < enemy2Place.x)
            {
                enemy2Place.x -= e2Speed;
            }
            if (playerRect.x > enemy2Place.x)
            {
                enemy2Place.x += e2Speed;
            }
            if (playerRect.y < enemy2Place.y)
            {
                enemy2Place.y -= e2Speed;
            }
            if (playerRect.y > enemy2Place.y)
            {
                enemy2Place.y += e2Speed;
            }
            if  (Raylib.CheckCollisionRecs(playerRect, enemy2Place))
            {
                health.width -= 50;
                X = generator.Next(1, 771);
                Y = generator.Next(1, 571);
                if (X == Raylib.CheckCollisionRecs(playerRect, enemy2Place) || Y == Raylib.CheckCollisionRecs(playerRect, enemy2Place))
                {
                    X = generator.Next(1, 801);
                    Y = generator.Next(1, 601);  
                }
                enemy2Place.y = Y;
                enemy2Place.x = X;
                if (mode == "Powered")
                {
                    if (armorBar.width < 100)
                    {
                        health.width -= 20;
                    }
                    if (armorBar.width > 99)
                    {
                        health.width -= 10;
                    }
                }
            }
        }
    }
    else if (currentScene == "start" || currentScene == "end")
    {
        //don't know if this one is even necessary
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
        {
            currentScene = "game";
        }
    }
    //Ded
    if (health.width < 0 || health.width == 0)
    {
        currentScene = "end";
    }
    //Graphics
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    //Game Graphics
    if (currentScene == "game")
    {
        //Random Backgrounds
        if (backGroundSelect == 1)
        {
            Raylib.DrawTexture(backGround1,
                0, 
                0, 
                Color.WHITE);
        }
        else if (backGroundSelect == 2)
        {
            Raylib.DrawTexture(backGround2,
                0, 
                0, 
                Color.WHITE);
        }
        else if (backGroundSelect == 3)
        {
            Raylib.DrawTexture(backGround3,
                0, 
                0, 
                Color.WHITE);
        }

        //Normal Doomguy
        if (mode == "Normal")
        {    
            Raylib.DrawTexture(powerUp, 
                (int)powerUpPlace.x,
                (int)powerUpPlace.y,
                Color.WHITE);
        }

        //Enemies
        if (points < 35)
        {
            foreach (Rectangle rect in enemies)
            {
                Raylib.DrawTexture(enemy1, (int)rect.x, (int)rect.y, Color.WHITE);
            }
        }

        //Projectile
        if (Raylib.IsKeyDown(KeyboardKey.KEY_L) || (Raylib.IsKeyDown(KeyboardKey.KEY_J)) || (Raylib.IsKeyDown(KeyboardKey.KEY_K)) || (Raylib.IsKeyDown(KeyboardKey.KEY_I)))
        {
            if (mode == "Powered")
            {
                Raylib.DrawTexture(playerProjectile, (int)playerProjectilePlace.x, (int)playerProjectilePlace.y, Color.WHITE);
            }
        }
        //Different types of powered
        if (mode == "Powered")
        {
            if(armorBar.width < 100 && points < 35)
            {
                Raylib.DrawTexture(avatarImagePowered2, 
                    (int)playerRect.x, 
                    (int)playerRect.y, 
                    Color.WHITE);
            }
            else if(armorBar.width > 99 || points > 34)
            {
                Raylib.DrawTexture(avatarImagePowered, 
                    (int)playerRect.x, 
                    (int)playerRect.y, 
                    Color.WHITE);
            }
        }
        else if (mode == "Normal")
        {
            Raylib.DrawTexture(avatarImage, 
                (int)playerRect.x, 
                (int)playerRect.y,
                Color.WHITE);
        }
        //Gold Dude
        if (points < 35)
        {
            Raylib.DrawTexture(goldDude, (int)goldDudePlace.x, (int)goldDudePlace.y, Color.WHITE);
        }

        //Statbars
        Raylib.DrawText($"Points: {points}", 650, 50, 30, Color.WHITE);
        Raylib.DrawRectangleRec(healthLost, Color.BLACK);
        Raylib.DrawRectangleRec(health, oxBlood);
        Raylib.DrawText("VEGGIE METER", 17, 12, 30, Color.RED);
        Raylib.DrawRectangleRec(armorLost, Color.BLACK);
        Raylib.DrawRectangleRec(armorBar, Color.BLUE);
        Raylib.DrawText("ARMOR", 17, 52, 20, Color.SKYBLUE);
        Raylib.DrawRectangleRec(staminaLost, Color.BLACK);
        Raylib.DrawRectangleRec(stamina, Color.GREEN);
        Raylib.DrawText("STAMINA", 497, 577, 20, Color.LIME);
        //Miniboss
        if (points > 34 && points < 69)
        {
            points = 35;
            Raylib.DrawTexture(miniBoss, (int)miniBossPlace.x, (int)miniBossPlace.y, Color.WHITE);
            Raylib.DrawTexture(miniBossProjectile, (int)miniBossProjectilePlace.x, (int)miniBossProjectilePlace.y, Color.WHITE);
            Raylib.DrawRectangleRec(miniBossHealthLost, Color.BLACK);
            Raylib.DrawRectangleRec(miniBossHealth, Color.RED);
            Raylib.DrawText("Sensei yugmooD", 620, 22, 20, Color.ORANGE);
            if (deleteTexts[0] < 3)
            {
                Raylib.DrawText(text[0], 10, textPlace[0], 15, Color.GOLD);
            }
            if (deleteTexts[0] < 3)
            {
                deleteTexts[0] += Raylib.GetFrameTime();
            }
        }
        //Big Daddy Doomguy
        if (points > 68)
        {
            if (deleteTexts[1] < 3)
            {
                Raylib.DrawText(text[1], 10, textPlace[1], 15, Color.GOLD);
            }
            if (deleteTexts[1] < 3)
            {
                deleteTexts[1] += Raylib.GetFrameTime();
            }
            if (deleteTexts[2] < 5)
            {
                if (deleteTexts[2] > 2)
                {
                    Raylib.DrawText(text[2], 10, textPlace[2], 15, Color.GOLD);
                    textPlace[1] = 460;
                }
            }
            if (deleteTexts[2] < 5)
            {
                deleteTexts[2] += Raylib.GetFrameTime();
            }
            if(bigDaddyDoomguyPlace.x < -200)
            {
                bigDaddyDoomguyPlace.x ++;
            }
            else if(bigDaddyDoomguyPlace.x == -200)
            {
                foreach(Rectangle rect in bossProjectiles)
                {
                    if(rect.x > -1 && E != 5)
                    {
                        Raylib.DrawTexture(bossProjectile, (int)rect.x, (int)rect.y, Color.WHITE);
                    }
                }
            } 
            Raylib.DrawTexture(bigDaddyDoomguy, (int)bigDaddyDoomguyPlace.x, (int)bigDaddyDoomguyPlace.y, Color.WHITE);
            if (bossHealthPhase1.width > 0)
            {
                Raylib.DrawText("Big Daddy Doomguy Phase: 1", 400, 22, 20, Color.ORANGE);
            }
            else if (bossHealthPhase2.width > 0 && E == 1)
            {
                bigDaddyDoomguy = Raylib.LoadTexture("BigBossPhase2.png");
                E++;
            }
            else if (bossHealthPhase2.width > 0 && E == 2)
            {
                Raylib.DrawText("Big Daddy Doomguy Phase: 2", 400, 22, 20, Color.ORANGE);
                if (deleteTexts[3] < 3)
                {
                    Raylib.DrawText(text[3], 10, textPlace[3], 15, Color.GOLD);
                }
                if (deleteTexts[3] < 3)
                {
                    deleteTexts[3] += Raylib.GetFrameTime();
                }
            }
            else if (bossHealthPhaseBezos.width > 0 && E == 3)
            {
                bigDaddyDoomguy = Raylib.LoadTexture("BigBossPhaseBezos.png");
                E++;
            }
            else if (bossHealthPhaseBezos.width > 0 && E == 4)
            {
                Raylib.DrawText("Big Daddy Doomguy Phase: Bezos", 400, 22, 20, Color.ORANGE);
                if (deleteTexts[4] < 3)
                {
                    Raylib.DrawText(text[4], 10, textPlace[4], 15, Color.GOLD);
                }
                if (deleteTexts[4] < 3)
                {
                    deleteTexts[4] += Raylib.GetFrameTime();
                }
                if (deleteTexts[5] < 5)
                {
                    if (deleteTexts[5] > 2)
                    {
                        Raylib.DrawText(text[5], 10, textPlace[5], 15, Color.GOLD);
                        textPlace[4] = 460;
                    }
                }
                if (deleteTexts[5] < 5)
                {
                    deleteTexts[5] += Raylib.GetFrameTime();
                }
            }
            else if (bossHealthPhaseBezos.width < 0 && E == 5)
            {
                if (deleteTexts[6] < 3)
                {
                    Raylib.DrawText(text[6], 10, textPlace[6], 15, Color.GOLD);
                }
                if (deleteTexts[6] < 3)
                {
                    deleteTexts[6] += Raylib.GetFrameTime();
                }
                if (deleteTexts[6] > 3)
                {
                    E++;
                    Console.WriteLine(E);
                }
            }
            else if (bossHealthPhaseBezos.width < 0 && E == 6)
            {
                bigDaddyDoomguy = Raylib.LoadTexture("BigBossPhaseJesusBezosPhase.png");
                E++;
            }
            else if (bossHealthPhaseBezos.width < 0 && E == 7)
            {
                Raylib.DrawText("Bezos Christ Our Lord And Saviour", 400, 22, 20, Color.ORANGE);
                if (deleteTexts[7] < 3)
                {
                    Raylib.DrawText(text[7], 10, textPlace[7], 15, Color.GOLD);
                }
                if (deleteTexts[7] < 3)
                {
                    deleteTexts[7] += Raylib.GetFrameTime();
                }
            }
            if(bossHealthPhaseBezos.width > 0)
            {
                Raylib.DrawRectangleRec(bossHealthLostPhase1, Color.BLACK);
                Raylib.DrawRectangleRec(bossHealthPhase1, Color.RED);
                Raylib.DrawRectangleRec(bossHealthLostPhase2, Color.BLACK);
                Raylib.DrawRectangleRec(bossHealthPhase2, Color.RED);
                Raylib.DrawRectangleRec(bossHealthLostPhaseBezos, Color.BLACK);
                Raylib.DrawRectangleRec(bossHealthPhaseBezos, Color.RED);
            }
            else if(bossHealthPhaseBezos.width < 0 && E == 7)
            {
                Raylib.DrawRectangleRec(bossHealthLostPhaseBezosChrist, Color.BLACK);
                Raylib.DrawRectangleRec(bossHealthPhaseBezosChrist, Color.RED);
            }
            if (bossHealthPhase1.width < 0 && bossLaserSpawn > 3 && E != 5)
            {
                Raylib.DrawTexture(bossLaser, (int)bossLaserPlace.x, (int)bossLaserPlace.y, Color.WHITE);
            }
            foreach (Rectangle rect in bossNuksBox)
            {
                if(rect.y < 0)
                {
                    Raylib.DrawTexture(bossAmazonClosed, (int)rect.x, (int)rect.y, Color.WHITE);
                }
                else if(rect.y >= 0)
                {
                    Raylib.DrawTexture(bossAmazonOpen, (int)rect.x, (int)rect.y, Color.WHITE);
                }
                if(rect.y == 0)
                {
                    Raylib.DrawTexture(bossNuk, (int)rect.x, (int)rect.y, Color.WHITE);
                }
            }
            foreach (Rectangle rect2 in bossNuks)
            {
                if(rect2.y > 0)
                {
                    Raylib.DrawTexture(bossNuk, (int)rect2.x, (int)rect2.y, Color.WHITE);
                    Console.WriteLine(600-bossNuk.width);
                    Console.WriteLine(rect2.y);
                }
                if(rect2.y >= 600-bossNuk.width)
                {
                    bossNuk = Raylib.LoadTexture("NukExplosion");
                }
            }
            if (bossLaserSpawn > 2 && bossLaserSpawn < 3 && E != 5)
            {
                Raylib.DrawTexture(bossLaserWarning, (int)bossLaserPlace.x, (int)bossLaserPlace.y, Color.WHITE);
            }
        }

        //energy/health/armor
        if(energySpawn > 9  && points < 35)
        {
            Raylib.DrawTexture(energyPack, 
                (int)energyPackPlace.x, 
                (int)energyPackPlace.y,
                Color.WHITE);
        }
        if(veggieSpawn > 4  && points < 69)
        {
            Raylib.DrawTexture(veggiePack, 
                (int)veggiePackPlace.x, 
                (int)veggiePackPlace.y,
                Color.WHITE);
        }
        if(points < 35)
        {
            if (mode == "Powered")
            {
                if(armorSpawn > 2)
                {
                    Raylib.DrawTexture(armorPack, 
                        (int)armorPackPlace.x, 
                        (int)armorPackPlace.y,
                        Color.WHITE);
                }
            }
        }

        //Enemy 2
        if (points > 19 && points < 35)
        {
            Raylib.DrawTexture(enemy2, 
                (int)enemy2Place.x, 
                (int)enemy2Place.y,
                Color.WHITE);
        }

        //Restart
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            health.width = 300;
            mode = "Normal";
            enemy1 = Raylib.LoadTexture("Monster1.png");
            currentScene = "start";
        }
    }
    else if (currentScene == "start")
    {
        //startscreen
        Raylib.DrawTexture(startScreen, 0, 0, Color.WHITE);
        Raylib.DrawTexture(bigDaddyDoomguy, (int)bigDaddyDoomguyPlace.x, (int)bigDaddyDoomguyPlace.y, Color.WHITE);
        Raylib.DrawText("Press ENTER to start", 100, 100, 50, Color.PINK);
        backGroundSelect = generator.Next(1,4);
        playerRect.x = 370;
        playerRect.y = 270;
        health.width = 300;
        mode = "Normal";
        X = generator.Next(1, 801);
        Y = generator.Next(1, 601);
        powerUpPlace.x = X;
        powerUpPlace.y = Y;
        for (int i = 0; i < enemies.Count; i++)
        {
            {
                Rectangle rect = enemies[i];
                X = generator.Next(50, 771);
                Y = generator.Next(50, 571);
                rect.y = Y;
                rect.x = X;
                enemies[i]=rect;
            }
        }
        X = generator.Next(1, 771);
        Y = generator.Next(1, 571);
        if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
        {
        X = generator.Next(1, 801);
        Y = generator.Next(1, 601);  
        }
        goldDudePlace.y = Y;
        goldDudePlace.x = X;
        
    }
    else if(currentScene == "end")
    {
        //Git gud
        Raylib.DrawTexture(gameOver, 0, 0, Color.WHITE);
        Raylib.DrawText("Git gud nub >:P", 300, 500, 50, oxBlood);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            projectileSpeed = 0.75f;
            health.width = 300;
            currentScene = "start";
            mode = "Normal";
            stamina.width = 300;
            bigDaddyDoomguy = Raylib.LoadTexture("bigBoss.png");
            bigDaddyDoomguyPlace.x = -805;
            for (int i = 0; i < enemies.Count; i++)
            {
                Rectangle rect = enemies[i];
                X = generator.Next(50, 771);
                Y = generator.Next(50, 571);
                rect.y = Y;
                rect.x = X;
                enemies[i]=rect;
            }
            X = generator.Next(1, 771);
            Y = generator.Next(1, 571);
            if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
            {
            X = generator.Next(1, 801);
            Y = generator.Next(1, 601);  
            }
            goldDudePlace.y = Y;
            goldDudePlace.x = X;
        }
    }
    else if(currentScene == "victory")
    {
        //Git gud
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            projectileSpeed = 0.75f;
            health.width = 300;
            currentScene = "start";
            mode = "Normal";
            stamina.width = 300;
            bigDaddyDoomguy = Raylib.LoadTexture("bigBoss.png");
            bigDaddyDoomguyPlace.x = -805;
            for (int i = 0; i < enemies.Count; i++)
            {
                Rectangle rect = enemies[i];
                X = generator.Next(50, 771);
                Y = generator.Next(50, 571);
                rect.y = Y;
                rect.x = X;
                enemies[i]=rect;
            }
            X = generator.Next(1, 771);
            Y = generator.Next(1, 571);
            if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
            {
            X = generator.Next(1, 801);
            Y = generator.Next(1, 601);  
            }
            goldDudePlace.y = Y;
            goldDudePlace.x = X;
        }
    }



    Raylib.EndDrawing();

}