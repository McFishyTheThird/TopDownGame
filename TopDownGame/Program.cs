using Raylib_cs;
Raylib.InitWindow(800, 600, "Williams Crinchtopia");
Raylib.SetTargetFPS(100);
Texture2D avatarImage = Raylib.LoadTexture("ActualTrueDoomguy.png");
Texture2D bossFight = Raylib.LoadTexture("BigBoss.png");
Texture2D avatarImagePowered = Raylib.LoadTexture("DoomPowerup.png");
Rectangle playerRect = new Rectangle(370, 270, avatarImage.width, avatarImage.height);
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
int points = 0;
Random Generator = new Random ();
int damage = Generator.Next(1,3);
Rectangle health = new Rectangle (10, 10, 300, 30);
Rectangle healthLost = new Rectangle (10, 10, 300, 30);
Rectangle stamina = new Rectangle (10, 575, 300, 20);
Rectangle staminaLost = new Rectangle (10, 575, 300, 20);
Rectangle ammo = new Rectangle (10, 560, 100, 10);
Rectangle ammoLost = new Rectangle (10, 560, 100, 10);
Rectangle armorBar = new Rectangle (10, 50, 200, 20);
Rectangle armorLost = new Rectangle (10, 50, 200, 20);
Texture2D powerUp = Raylib.LoadTexture("Power up.png");
Texture2D healthPack = Raylib.LoadTexture("HealthPack.png");
Texture2D armorPack = Raylib.LoadTexture("ArmorPack.png");
Texture2D ammoPack = Raylib.LoadTexture("AmmoPack.png");
Texture2D energyPack = Raylib.LoadTexture("EnergyBattery.png");
Texture2D Enemy1 = Raylib.LoadTexture("Monster1.png");
Texture2D Enemy2 = Raylib.LoadTexture("Monster2.png");
Texture2D miniBoss = Raylib.LoadTexture("Monster3.png");
int X = Generator.Next(50, 801);
int Y = Generator.Next(50, 601);
Rectangle healthPackPlace = new Rectangle(X, Y, healthPack.width, healthPack.height);
Rectangle armorPackPlace = new Rectangle(X, Y, armorPack.width, armorPack.height);
Rectangle ammoPackPlace = new Rectangle(X, Y, ammoPack.width, ammoPack.height);
Rectangle energyPackPlace = new Rectangle(X, Y, energyPack.width, energyPack.height);
Rectangle enemy1Place = new Rectangle(X, Y, 50, 50);
Rectangle playerProjectilePlace = new Rectangle(0, 0, playerProjectile.width, playerProjectile.height);
Rectangle bossProjectilePlace = new Rectangle(0, 0, bossProjectile.width, bossProjectile.height);
Rectangle enemy2Place = new Rectangle(X, Y, 50, 50);
Rectangle miniBossPlace = new Rectangle(X, Y, 50, 50);
Rectangle bossFightPlace = new Rectangle(-805, 0, 50, 50);
string energyMode = "off";
string ammoMode = "off";
string healthMode = "off";
string armorMode = "off";
int powerPack = Generator.Next(1, 201);
int armor = 5;
int backGroundSelect = Generator.Next(1,4);
X = Generator.Next(50, 801);
Y = Generator.Next(50, 601);
Rectangle powerUpPlace = new Rectangle(X, Y, 30, 30);
string mode = "Normal";
float speed = 3;
float eSpeed = 2;

float e2Speed = 1;
string currentScene = "start"; //start, game, end
while(Raylib.WindowShouldClose() == false)
{
    if (points < 50)
    {
        eSpeed = 2;
    }
    else if(points > 49)
    {
        eSpeed = 1;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
    {
        if (stamina.width > 0)
        {
            speed = 5;
        }
        else
        {
            speed = 3;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            stamina.width -= 2;
        }
        if (stamina.width < 0)
        {
            stamina.width = 0;
        }
    }
    else
    {
        speed = 3;
    }
    if (playerRect.x < 0-avatarImage.width)
    {
        playerRect.x = 800+avatarImage.width;
    }
    else if (playerRect.y < 0-avatarImage.height)
    {
        playerRect.y = 600+avatarImage.height;;
    }
    else if (playerRect.x > 800+avatarImage.width)
    {
        playerRect.x = 0-avatarImage.width;
    }
    else if (playerRect.y > 600+avatarImage.height)
    {
        playerRect.y = 0-avatarImage.height;
    }
    if (currentScene == "game")
    {
        if (points < 75)
        {
            if (playerRect.x < enemy1Place.x)
            {
                enemy1Place.x -= eSpeed;
            }
            if (playerRect.x > enemy1Place.x)
            {
                enemy1Place.x += eSpeed;
            }
            if (playerRect.y < enemy1Place.y)
            {
                enemy1Place.y -= eSpeed;
            }
            if (playerRect.y > enemy1Place.y)
            {
                enemy1Place.y += eSpeed;
            }
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
            if (playerRect.x < powerUpPlace.x+powerUp.width && playerRect.x > powerUpPlace.x-avatarImage.width && playerRect.y < powerUpPlace.y+powerUp.height && playerRect.y > powerUpPlace.y-avatarImage.height)
            {
                mode = "Powered";
                playerRect.width = powerUp.width;
                playerRect.height = powerUp.height;
                X = Generator.Next(50, 771);
                Y = Generator.Next(50, 571);
                powerUpPlace.x = X;
                powerUpPlace.y = Y;
                armor = 5; 
                armorBar.width = 200;
            }
            if (energyMode == "off")
            {
                powerPack = Generator.Next(1, 2);
            }
            if(powerPack == 1)
            {
                energyMode = "on";
                if (playerRect.x < energyPackPlace.x+energyPack.width && playerRect.x > energyPackPlace.x-avatarImage.width && playerRect.y < energyPackPlace.y+energyPack.height && playerRect.y > energyPackPlace.y-avatarImage.height)
                {
                    X = Generator.Next(50, 771);
                    Y = Generator.Next(50, 571);
                    energyPackPlace.x = X;
                    energyPackPlace.y = Y;
                    stamina.width += 25;
                    energyMode = "off";
                }
            }
        }
        if (points < 75)
        {
            if (mode == "Normal")
            {
                if  (playerRect.x < enemy1Place.x+Enemy1.width && playerRect.x > enemy1Place.x - avatarImage.width && playerRect.y < enemy1Place.y+Enemy1.height && playerRect.y > enemy1Place.y-avatarImage.height )
                {
                    health.width -= 10;
                    X = Generator.Next(1, 771);
                    Y = Generator.Next(1, 571);
                    if (X == playerRect.x || Y == playerRect.y)
                    {
                        X = Generator.Next(1, 801);
                        Y = Generator.Next(1, 601);  
                    }
                    enemy1Place.y = Y;
                    enemy1Place.x = X;
                }
            }
            else if (mode == "Powered")
            {
                if  (playerRect.x < enemy1Place.x+Enemy1.width && playerRect.x+avatarImage.width > enemy1Place.x-powerUp.width && playerRect.y < enemy1Place.y+Enemy1.height && playerRect.y > enemy1Place.y-powerUp.height )
                {    
                    health.width += 5;
                    points ++;
                    if (health.width > healthLost.width)
                    {
                        health.width = healthLost.width;
                    }
                    damage = Generator.Next(1,3);
                    armor -= damage;
                    if (damage == 1)
                    {
                        armorBar.width -= 40;
                    }
                    else if (damage == 2)
                    {
                        armorBar.width -= 80;
                    }
                    X = Generator.Next(1, 771);
                    Y = Generator.Next(1, 571);
                    if (X == playerRect.x && X == playerRect.x+avatarImage.width && Y == playerRect.y && Y ==playerRect.y)
                    {
                        X = Generator.Next(1, 801);
                        Y = Generator.Next(1, 601);  
                    }
                    enemy1Place.y = Y;
                    enemy1Place.x = X;
                    if (armor == 0 || armor < 0)
                    {
                        mode = "Normal";
                        playerRect.height = avatarImage.height;
                        playerRect.width = avatarImage.width;
                    }
                }
            }
        }
        if (points > 20 && points < 50)
        {
            if (mode == "Normal")
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
                if  (playerRect.x < enemy2Place.x+Enemy2.width && playerRect.x > enemy2Place.x-Enemy2.width && playerRect.y < enemy2Place.y+Enemy2.height && playerRect.y > enemy2Place.y-Enemy2.height )
                {
                    health.width -= 50;
                    X = Generator.Next(1, 771);
                    Y = Generator.Next(1, 571);
                    if (X == playerRect.x || Y == playerRect.y)
                    {
                        X = Generator.Next(1, 801);
                        Y = Generator.Next(1, 601);  
                    }
                    enemy2Place.y = Y;
                    enemy2Place.x = X;
                }
            }
            else if (mode == "Powered")
            {
                armor = 2;
                armorBar.width = 80;
                if (playerRect.x < enemy2Place.x)
                {
                    enemy2Place.x += e2Speed;
                }
                if (playerRect.x > enemy2Place.x)
                {
                    enemy2Place.x -= e2Speed;
                }
                if (playerRect.y < enemy2Place.y)
                {
                    enemy2Place.y += e2Speed;
                }
                if (playerRect.y > enemy2Place.y)
                {
                    enemy2Place.y -= e2Speed;
                }

            }
        }
        if (points > 49)
        {
            eSpeed = 1;
            Enemy1 = miniBoss;
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
        if (points < 75)
        {
            Raylib.DrawTexture(Enemy1, 
                (int)enemy1Place.x,
                (int)enemy1Place.y,
                Color.WHITE);
        }
        if (mode == "Powered")
        {
            Raylib.DrawTexture(avatarImagePowered, 
                (int)playerRect.x, 
                (int)playerRect.y, 
                Color.WHITE);
        }
        else if (mode == "Normal")
        {
            Raylib.DrawTexture(avatarImage, 
                (int)playerRect.x, 
                (int)playerRect.y,
                Color.WHITE);
        }
        Raylib.DrawText($"Points: {points}", 650, 50, 30, Color.WHITE);
        Raylib.DrawRectangleRec(healthLost, Color.BLACK);
        Raylib.DrawRectangleRec(health, OxBlood);
        Raylib.DrawText("HEALTH", 17, 12, 30, Color.RED);
        Raylib.DrawRectangleRec(armorLost, Color.BLACK);
        Raylib.DrawRectangleRec(armorBar, Color.BLUE);
        Raylib.DrawText("ARMOR", 17, 52, 20, Color.SKYBLUE);
        Raylib.DrawRectangleRec(ammoLost, Color.BLACK);
        Raylib.DrawRectangleRec(ammo, Color.GOLD);
        Raylib.DrawText("AMMO", 17, 560, 10, Color.BLACK);
        Raylib.DrawRectangleRec(staminaLost, Color.BLACK);
        Raylib.DrawRectangleRec(stamina, Color.GREEN);
        Raylib.DrawText("STAMINA", 17, 577, 20, Color.LIME);
        if (points > 20 && points < 50)
        {
            Raylib.DrawTexture(Enemy2, 
                (int)enemy2Place.x, 
                (int)enemy2Place.y,
                Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            armor = 5;
            health.width = 300;
            mode = "Normal";
            Enemy1 = Raylib.LoadTexture("Monster1.png");
            eSpeed = 2;
            currentScene = "start";
        }
    }
    else if (currentScene == "start")
    {
        Raylib.DrawTexture(startScreen, 0, 0, Color.WHITE);
        Raylib.DrawTexture(bossFight, (int)bossFightPlace.x, (int)bossFightPlace.y, Color.WHITE);
        Raylib.DrawText("Press ENTER to start", 100, 100, 50, Color.PINK);
        backGroundSelect = Generator.Next(1,4);
        enemy1Place.y = (300);
        enemy1Place.x = (50);
        playerRect.x = 370;
        playerRect.y = 270;
        health.width = 300;
        mode = "Normal";
        armor = 5;
        X = Generator.Next(1, 801);
        Y = Generator.Next(1, 601);
        powerUpPlace.x = X;
        powerUpPlace.y = Y;
    }
    else if(currentScene == "end")
    {
        Raylib.DrawTexture(gameOver, 0, 0, Color.WHITE);
        Raylib.DrawText("You Lost", 300, 500, 50, OxBlood);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_TAB))
        {
            points = 0;
            armor = 5;
            health.width = 300;
            currentScene = "start";
            mode = "Normal";
            Enemy1 = Raylib.LoadTexture("Monster1.png");
            eSpeed = 2;
        }
    }



    Raylib.EndDrawing();

}