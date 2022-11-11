using Raylib_cs;
Raylib.InitWindow(800, 600, "Williams Crinchtopia");
Raylib.SetTargetFPS(100);
Raylib.InitAudioDevice();
Texture2D avatarImage = Raylib.LoadTexture("ActualTrueDoomguy.png");
Texture2D bigDaddyDoomguy = Raylib.LoadTexture("BigBoss.png");
Texture2D bigDaddyDoomguyMad = Raylib.LoadTexture("BigBossPhase2.png");
Texture2D bigDaddyBezos = Raylib.LoadTexture("BigBossPhaseBezos.png");
Texture2D avatarImagePowered = Raylib.LoadTexture("DoomPowerup2.png");
Texture2D avatarImagePowered2 = Raylib.LoadTexture("DoomPowerup.png");
Texture2D backGround1 = Raylib.LoadTexture("Background1.png");
Texture2D backGround2 = Raylib.LoadTexture("Background2.png");
Texture2D backGround3 = Raylib.LoadTexture("Background3.png");
Texture2D playerProjectile = Raylib.LoadTexture("PlayerProjectile.png");
Texture2D bossProjectile = Raylib.LoadTexture("BossProjectile.png");
Texture2D gameOver = Raylib.LoadTexture("GameOver.png");
Texture2D startScreen = Raylib.LoadTexture("Thetruedoomsotry.png");
Color Pantone448C = new Color(74, 65, 42, 255);
Color Arsenik = new Color(59, 68, 75, 255);
Color OxBlood = new Color(74, 4, 4, 255);
int points = 34;
Random Generator = new Random ();
int damage = Generator.Next(1,3);
Rectangle health = new Rectangle (10, 10, 300, 30);
Rectangle healthLost = new Rectangle (10, 10, 300, 30);
Rectangle miniBosshealth = new Rectangle (470, 10, 300, 10);
Rectangle miniBosshealthLost = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthPhase1 = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthLostPhase1 = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthPhase2 = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthLostPhase2 = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthPhaseBezos = new Rectangle (10, 10, 300, 10);
Rectangle BosshealthLostPhaseBezos = new Rectangle (10, 10, 300, 10);
Rectangle stamina = new Rectangle (10, 575, 300, 20);
Texture2D miniBossProjectile = Raylib.LoadTexture("MiniBossProjectile.png");
Rectangle staminaLost = new Rectangle (10, 575, 300, 20);
Rectangle ammo = new Rectangle (10, 560, 100, 10);
Rectangle ammoLost = new Rectangle (10, 560, 100, 10);
Rectangle armorBar = new Rectangle (10, 50, 200, 20);
Rectangle armorLost = new Rectangle (10, 50, 200, 20);
Texture2D powerUp = Raylib.LoadTexture("Power up.png");
Texture2D veggiePack = Raylib.LoadTexture("veggiePack.png");
Texture2D armorPack = Raylib.LoadTexture("ArmorPack.png");
Texture2D murricaPack = Raylib.LoadTexture("AmmoPack.png");
Texture2D energyPack = Raylib.LoadTexture("EnergyBattery.png");
Texture2D Enemy1 = Raylib.LoadTexture("Monster1.png");
Texture2D Enemy2 = Raylib.LoadTexture("Monster2.png");
Texture2D miniBoss = Raylib.LoadTexture("Monster3.png");
Rectangle playerRect = new Rectangle(370, 270, avatarImage.width, avatarImage.height);
List<Rectangle> enemies = new List<Rectangle>();
List<Rectangle> miniBossProjectiles = new List<Rectangle>();
Music RipAndTear = Raylib.LoadMusicStream("Rip_Tear.mp3");
Music HellOnEarth = Raylib.LoadMusicStream("Hell On Earth.mp3");
Music bigDaddyDoomguyTheme = Raylib.LoadMusicStream("Cultist Base.mp3");
Music bigAngryDoomguyTheme = Raylib.LoadMusicStream("BFG Division.mp3");
Music bigDaddyBezosTheme = Raylib.LoadMusicStream("Metal Hell.mp3");
Music jesusBezosThemeSong = Raylib.LoadMusicStream("The Only Thing They Fear Is You.mp3");
int X = Generator.Next(50, 801);
int Y = Generator.Next(50, 601);
for (int i = 0; i < 4; i++)
{
    enemies.Add(new Rectangle(X, Y, Enemy1.width, Enemy1.height));
    X = Generator.Next(50, 801);
    Y = Generator.Next(50, 601);
}

Texture2D goldDude = Raylib.LoadTexture("GoldenDuumguyB).png");
enemies.Add(new Rectangle(X, Y, Enemy1.width, Enemy1.height));
Rectangle goldDudePlace = new Rectangle(X, Y, goldDude.width, goldDude.height);
Rectangle miniBossProjectilePlace = new Rectangle(X, 601, miniBossProjectile.width, miniBossProjectile.height);
Rectangle veggiePackPlace = new Rectangle(X, Y, veggiePack.width, veggiePack.height);
Rectangle armorPackPlace = new Rectangle(X, Y, armorPack.width, armorPack.height);
Rectangle murricaPackPlace = new Rectangle(X, Y, murricaPack.width, murricaPack.height);
Rectangle energyPackPlace = new Rectangle(X, Y, energyPack.width, energyPack.height);
Rectangle playerProjectilePlace = new Rectangle(0, 0, playerProjectile.width, playerProjectile.height);
Rectangle bossProjectilePlace = new Rectangle(0, 0, bossProjectile.width, bossProjectile.height);
Rectangle enemy2Place = new Rectangle(X, Y, 50, 50);
Rectangle bigDaddyDoomguyPlace = new Rectangle(-805, 0, 50, 50);
int powerPack = Generator.Next(1, 201);
int healthyPack = Generator.Next(1, 201);
int stronkPack = Generator.Next(1, 201);
int gunPack = Generator.Next(1, 201);
int backGroundSelect = Generator.Next(1,4);
X = Generator.Next(50, 801);
Y = Generator.Next(50, 601);
Rectangle powerUpPlace = new Rectangle(X, Y, 30, 30);
string mode = "Normal";
float speed = 3;
float projectileSpeed = 0.75f;
float megaSpeeeeeeed = 3.1f;
float e2Speed = 1;
float energySpawn = 0;
float veggieSpawn = 0;
float murricaSpawn = 0;
float armorSpawn = 0;
string currentScene = "start"; //start, game, end
while(Raylib.WindowShouldClose() == false)
{
    if (points < 50 && points > 34)
    {
        Raylib.PlayMusicStream(HellOnEarth);
        Raylib.UpdateMusicStream(HellOnEarth);
        Raylib.StopMusicStream(RipAndTear);
        if(miniBossProjectilePlace.y > 600)
        {
            X = Generator.Next(50, 701);
            miniBossProjectilePlace.x = X;
            miniBossProjectilePlace.y ++;
        }
        
    }
    if (currentScene == "game")
    {
        Raylib.UpdateMusicStream(RipAndTear);
        if (mode == "Powered")
        {
            playerRect.width = avatarImagePowered.width;
            playerRect.height = avatarImagePowered.height;
            if(points < 35)
            {
                Raylib.PlayMusicStream(RipAndTear);
            }
        }
        else
        {
            playerRect.width = avatarImage.width;
            playerRect.height = avatarImage.height;
            Raylib.StopMusicStream(RipAndTear);
        }
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
                    if (Raylib.CheckCollisionRecs(playerProjectilePlace, rect))
                    {
                        X = Generator.Next(1, 771);
                        Y = Generator.Next(1, 571);
                        if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                        {
                            X = Generator.Next(1, 801);
                            Y = Generator.Next(1, 601);  
                        }
                        rect.y = Y;
                        rect.x = X;
                        playerProjectilePlace.y = playerRect.y;
                        playerProjectilePlace.x = playerRect.x;
                    }
                }
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
                            X = Generator.Next(1, 771);
                            Y = Generator.Next(1, 571);
                            if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                            {
                                X = Generator.Next(1, 801);
                                Y = Generator.Next(1, 601);  
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
                            X = Generator.Next(1, 771);
                            Y = Generator.Next(1, 571);
                            if (X == Raylib.CheckCollisionRecs(playerRect, rect) || Y == Raylib.CheckCollisionRecs(playerRect, rect))
                            {
                                X = Generator.Next(1, 801);
                                Y = Generator.Next(1, 601);  
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
                if (Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
                {
                    int pointIncrease = Generator.Next(1, 3 );
                    points += pointIncrease;
                    X = Generator.Next(1, 771);
                    Y = Generator.Next(1, 571);
                    if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
                    {
                    X = Generator.Next(1, 801);
                    Y = Generator.Next(1, 601);  
                    }
                    goldDudePlace.y = Y;
                    goldDudePlace.x = X;
                }
                enemies[i] = rect;
            }
        }
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
        if (mode == "Normal")
        {
            if (Raylib.CheckCollisionRecs(playerRect, powerUpPlace))
            {
                mode = "Powered";
                X = Generator.Next(50, 771);
                Y = Generator.Next(50, 571);
                powerUpPlace.x = X;
                powerUpPlace.y = Y;
                armorBar.width = 200;
            }
        }
        if (points > 34)
        {
                mode = "Powered";
                projectileSpeed = 4;
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
        }
                energySpawn += Raylib.GetFrameTime();
                if(energySpawn > 9)
                {
                    if (Raylib.CheckCollisionRecs(playerRect, energyPackPlace))
                    {
                        if(points < 35)
                        {
                            X = Generator.Next(50, 750);
                            Y = Generator.Next(50, 550);
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
                veggieSpawn += Raylib.GetFrameTime();
                if(veggieSpawn > 4)
                {
                    if (Raylib.CheckCollisionRecs(playerRect, veggiePackPlace))
                    {
                        if(points < 35)
                        {
                            X = Generator.Next(50, 750);
                            Y = Generator.Next(50, 550);
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
                if(mode == "Powered")
                {
                    armorSpawn += Raylib.GetFrameTime();
                    if(armorSpawn > 2)
                    {
                        if (Raylib.CheckCollisionRecs(playerRect, armorPackPlace))
                        {
                            if(points < 35)
                            {
                                X = Generator.Next(50, 750);
                                Y = Generator.Next(50, 550);
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
                murricaSpawn += Raylib.GetFrameTime();
                if(murricaSpawn > 15 && ammo.width < ammoLost.width)
                {
                    if (Raylib.CheckCollisionRecs(playerRect, murricaPackPlace))
                    {
                        if(points < 35)
                        {
                            X = Generator.Next(50, 750);
                            Y = Generator.Next(50, 550);
                            murricaPackPlace.x = X;
                            murricaPackPlace.y = Y;
                        }
                        ammo.width += 100;
                        if (ammo.width > ammoLost.width)
                        {
                            ammo.width = ammoLost.width;
                        }
                        murricaSpawn = 0;
                    }
                }
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
                X = Generator.Next(1, 771);
                Y = Generator.Next(1, 571);
                if (X == Raylib.CheckCollisionRecs(playerRect, enemy2Place) || Y == Raylib.CheckCollisionRecs(playerRect, enemy2Place))
                {
                    X = Generator.Next(1, 801);
                    Y = Generator.Next(1, 601);  
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
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
        {
            currentScene = "game";
        }
    }
    if (health.width < 0 || health.width == 0)
    {
        currentScene = "end";
    }
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    if (currentScene == "game")
    {
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
        if (mode == "Normal")
        {    
            Raylib.DrawTexture(powerUp, 
                (int)powerUpPlace.x,
                (int)powerUpPlace.y,
                Color.WHITE);
        }
        if (points < 35)
        {
            foreach (Rectangle rect in enemies)
            {
                Raylib.DrawTexture(Enemy1, (int)rect.x, (int)rect.y, Color.WHITE);
            }
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_L) || (Raylib.IsKeyDown(KeyboardKey.KEY_J)) || (Raylib.IsKeyDown(KeyboardKey.KEY_K)) || (Raylib.IsKeyDown(KeyboardKey.KEY_I)))
        {
            if (mode == "Powered")
            {
                Raylib.DrawTexture(playerProjectile, (int)playerProjectilePlace.x, (int)playerProjectilePlace.y, Color.WHITE);
            }
        }
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
        if (points < 35)
        {
            Raylib.DrawTexture(goldDude, (int)goldDudePlace.x, (int)goldDudePlace.y, Color.WHITE);
        }
        Raylib.DrawText($"Points: {points}", 650, 50, 30, Color.WHITE);
        Raylib.DrawRectangleRec(healthLost, Color.BLACK);
        Raylib.DrawRectangleRec(health, OxBlood);
        Raylib.DrawText("VEGGIE METER", 17, 12, 30, Color.RED);
        Raylib.DrawRectangleRec(armorLost, Color.BLACK);
        Raylib.DrawRectangleRec(armorBar, Color.BLUE);
        Raylib.DrawText("ARMOR", 17, 52, 20, Color.SKYBLUE);
        Raylib.DrawRectangleRec(ammoLost, Color.BLACK);
        Raylib.DrawRectangleRec(ammo, Color.GOLD);
        Raylib.DrawText("AMMO", 17, 560, 10, Color.BLACK);
        Raylib.DrawRectangleRec(staminaLost, Color.BLACK);
        Raylib.DrawRectangleRec(stamina, Color.GREEN);
        Raylib.DrawText("STAMINA", 17, 577, 20, Color.LIME);
        if (points > 34 && points < 50)
        {
            Raylib.DrawTexture(miniBoss, 230, 270, Color.WHITE);
            Raylib.DrawTexture(miniBossProjectile, (int)miniBossProjectilePlace.x, (int)miniBossProjectilePlace.y, Color.WHITE);
            Raylib.DrawRectangleRec(miniBosshealth, OxBlood);
            Raylib.DrawText("Sensei yugmooD", 610, 22, 20, Color.ORANGE);
        }
        if(energySpawn > 9)
        {
            Raylib.DrawTexture(energyPack, 
                (int)energyPackPlace.x, 
                (int)energyPackPlace.y,
                Color.WHITE);
        }
        if(veggieSpawn > 4)
        {
            Raylib.DrawTexture(veggiePack, 
                (int)veggiePackPlace.x, 
                (int)veggiePackPlace.y,
                Color.WHITE);
        }
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
        if (ammo.width < ammoLost.width)
        {
            if(murricaSpawn > 14)
            {
                Raylib.DrawTexture(murricaPack, 
                    (int)murricaPackPlace.x, 
                    (int)murricaPackPlace.y,
                    Color.WHITE);
            }
        }
        if (points > 19 && points < 35)
        {
            Raylib.DrawTexture(Enemy2, 
                (int)enemy2Place.x, 
                (int)enemy2Place.y,
                Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            health.width = 300;
            mode = "Normal";
            Enemy1 = Raylib.LoadTexture("Monster1.png");
            currentScene = "start";
        }
    }
    else if (currentScene == "start")
    {
        Raylib.DrawTexture(startScreen, 0, 0, Color.WHITE);
        Raylib.DrawTexture(bigDaddyDoomguy, (int)bigDaddyDoomguyPlace.x, (int)bigDaddyDoomguyPlace.y, Color.WHITE);
        Raylib.DrawText("Press ENTER to start", 100, 100, 50, Color.PINK);
        backGroundSelect = Generator.Next(1,4);
        playerRect.x = 370;
        playerRect.y = 270;
        health.width = 300;
        mode = "Normal";
        X = Generator.Next(1, 801);
        Y = Generator.Next(1, 601);
        powerUpPlace.x = X;
        powerUpPlace.y = Y;
        for (int i = 0; i < enemies.Count; i++)
        {
            {
                Rectangle rect = enemies[i];
                X = Generator.Next(50, 771);
                Y = Generator.Next(50, 571);
                rect.y = Y;
                rect.x = X;
                enemies[i]=rect;
            }
        }
        X = Generator.Next(1, 771);
        Y = Generator.Next(1, 571);
        if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
        {
        X = Generator.Next(1, 801);
        Y = Generator.Next(1, 601);  
        }
        goldDudePlace.y = Y;
        goldDudePlace.x = X;
        
    }
    else if(currentScene == "end")
    {
        Raylib.DrawTexture(gameOver, 0, 0, Color.WHITE);
        Raylib.DrawText("You Lost", 300, 500, 50, OxBlood);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            projectileSpeed = 0.75f;
            health.width = 300;
            currentScene = "start";
            mode = "Normal";
            stamina.width = 300;
            for (int i = 0; i < enemies.Count; i++)
            {
                Rectangle rect = enemies[i];
                X = Generator.Next(50, 771);
                Y = Generator.Next(50, 571);
                rect.y = Y;
                rect.x = X;
                enemies[i]=rect;
            }
            X = Generator.Next(1, 771);
            Y = Generator.Next(1, 571);
            if (X == Raylib.CheckCollisionRecs(playerRect, goldDudePlace) || Y == Raylib.CheckCollisionRecs(playerRect, goldDudePlace))
            {
            X = Generator.Next(1, 801);
            Y = Generator.Next(1, 601);  
            }
            goldDudePlace.y = Y;
            goldDudePlace.x = X;
        }
    }



    Raylib.EndDrawing();

}