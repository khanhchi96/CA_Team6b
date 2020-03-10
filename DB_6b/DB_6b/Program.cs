using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DB_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            Seed1();
            Seed2();
        }

        static void Seed1()
        {
            using (var db = new Model1Container())
            {               
                Product borderlands3 = new Product();
                borderlands3.ProductName = "BORDERLANDS 3";
                borderlands3.Genre = "Action, RPG";
                borderlands3.Developer = "Gearbox Software";
                borderlands3.Publisher = "2K";
                borderlands3.Platform = "EPIC Games store" + "Windows";
                borderlands3.OperatingSystem = "Windows";
                borderlands3.ESRB = "M17+";
                borderlands3.Price = (double)59.99;
                borderlands3.ReleaseDate = Convert.ToDateTime("28/09/2019");
                borderlands3.Discount = 0;
                borderlands3.DiscountStart = Convert.ToDateTime("3/10/2019");
                borderlands3.DiscountEnd = Convert.ToDateTime("3/10/2019");
                borderlands3.Description =
                        "The original shooter-looter returns, packing bazillions of guns and an all-new mayhem-fueled adventure! Blast through new worlds and enemies as one of four brand new Vault Hunters – the ultimate treasure-seeking badasses of the Borderlands, each with deep skill trees, abilities and customization. Play solo or join with friends to take on insane enemies, score loads of loot and save your home from the most ruthless cult leaders in the galaxy.";
                borderlands3.NumOfSales = 2513;
                db.Products.Add(borderlands3);

                Product Destiny2SDDE = new Product();
                Destiny2SDDE.ProductName = "DESTINY 2_SHADOWKEEP DIGITAL DELUXE EDITION";
                Destiny2SDDE.Genre = "Action, Adventure";
                Destiny2SDDE.Developer = "Bungie";
                Destiny2SDDE.Publisher = "Bungie";
                Destiny2SDDE.Platform = "EPIC Games store" + "Windows";
                Destiny2SDDE.OperatingSystem = "Windows";
                Destiny2SDDE.ESRB = "T";
                Destiny2SDDE.Price = (double)59.99;
                Destiny2SDDE.ReleaseDate = Convert.ToDateTime("3/08/2019");
                Destiny2SDDE.Discount = 15;
                Destiny2SDDE.DiscountStart = Convert.ToDateTime("3/10/2019");
                Destiny2SDDE.DiscountEnd = Convert.ToDateTime("3/10/2019");
                Destiny2SDDE.Description =
                        "New nightmares have emerged from the shadows of our Moon. Called forth by haunting visions, Eris Morn has returned. Join her to slay these nightmares before they reach out beyond the Moon to cast humanity back into an age of darkness.";
                Destiny2SDDE.NumOfSales = 1231;
                db.Products.Add(Destiny2SDDE);

                Product Destiny2s = new Product();
                Destiny2s.ProductName = "DESTINY 2_SHADOWKEEP";
                Destiny2s.Genre = "Action, Adventure";
                Destiny2s.Developer = "Bungie";
                Destiny2s.Publisher = "Bungie";
                Destiny2s.Platform = "EPIC Games store" + "Windows";
                Destiny2s.OperatingSystem = "Windows";
                Destiny2s.ESRB = "T";
                Destiny2s.Price = (double)34.99;
                Destiny2s.ReleaseDate = Convert.ToDateTime("3/08/2019");
                Destiny2s.Discount = 5;
                Destiny2s.DiscountStart = Convert.ToDateTime("3/10/2019");
                Destiny2s.DiscountEnd = Convert.ToDateTime("3/10/2019");
                Destiny2s.Description =
                        "New nightmares have emerged from the shadows of our Moon. Called forth by haunting visions, Eris Morn has returned. Join her to slay these nightmares before they reach out beyond the Moon to cast humanity back into an age of darkness.";
                Destiny2s.NumOfSales = 7213;
                db.Products.Add(Destiny2s);

                Product codeVein = new Product();
                codeVein.ProductName = "CODE VEIN";
                codeVein.Genre = "Action,RPG";
                codeVein.Developer = "BANDAI NAMCO Studios Inc.";
                codeVein.Publisher = "BANDAI NAMCO Entertainment";
                codeVein.Platform = "Steam,Windows";
                codeVein.OperatingSystem = "Windows";
                codeVein.ESRB = "M17+";
                codeVein.Price = (double)59.99;
                codeVein.ReleaseDate = Convert.ToDateTime("4/10/2019");
                codeVein.Discount = 0;
                codeVein.DiscountStart = Convert.ToDateTime("3/10/2019");
                codeVein.DiscountEnd = Convert.ToDateTime("3/10/2019");
                codeVein.Description = "In the face of certain death, we rise.";
                codeVein.NumOfSales = 789;
                db.Products.Add(codeVein);

                Product CODBlackOps = new Product();
                CODBlackOps.ProductName = "CALL OF DUTY®_BLACK OPS III - ZOMBIES DELUXE";
                CODBlackOps.Genre = "Action, Adventure";
                CODBlackOps.Developer = "Treyarch, Aspyr (Mac)";
                CODBlackOps.Publisher = "Activision, Aspyr (Mac)";
                CODBlackOps.Platform = "Steam, Windows, Mac";
                CODBlackOps.OperatingSystem = "Windows";
                CODBlackOps.ESRB = "M17+";
                CODBlackOps.Price = (double)49.99;
                CODBlackOps.ReleaseDate = Convert.ToDateTime("23/6/2018");
                CODBlackOps.Discount = 0;
                CODBlackOps.DiscountStart = Convert.ToDateTime("3/10/2019");
                CODBlackOps.DiscountEnd = Convert.ToDateTime("3/10/2019");
                CODBlackOps.Description = "Call of Duty: Black Ops III is available now on Mac!";
                CODBlackOps.NumOfSales = 6999;
                db.Products.Add(CODBlackOps);

                Product XCOMCollection = new Product();
                XCOMCollection.ProductName = "XCOM® 2 COLLECTION";
                XCOMCollection.Genre = "Strategy";
                XCOMCollection.Developer = "Firaxis, Feral Interactive (Mac & Linux)";
                XCOMCollection.Publisher = "2K, Feral Interactive (Mac & Linux)";
                XCOMCollection.Platform = "Windows, Mac, Linux";
                XCOMCollection.OperatingSystem = "Windows";
                XCOMCollection.ESRB = "T";
                XCOMCollection.Price = (double)39.99;
                XCOMCollection.ReleaseDate = Convert.ToDateTime("30/11/2018");
                XCOMCollection.Discount = 25;
                XCOMCollection.DiscountStart = Convert.ToDateTime("3/10/2019");
                XCOMCollection.DiscountEnd = Convert.ToDateTime("3/10/2019");
                XCOMCollection.Description =
                        "Aliens rule Earth, promising a brilliant future for mankind while secretly hiding a sinister agenda. As the leader of a guerrilla force facing impossible odds, you must ignite a global resistance to eliminate the alien threat and save the hum race from extinction.";
                XCOMCollection.NumOfSales = 6372;
                db.Products.Add(XCOMCollection);

                Product NOTIA = new Product();
                NOTIA.ProductName = "NOITA";
                NOTIA.Genre = "Action, Indie, Adventure, RPG";
                NOTIA.Developer = "Nolla Games";
                NOTIA.Publisher = "Nolla Games";
                NOTIA.Platform = "Steam, Windows";
                NOTIA.OperatingSystem = "Windows";
                NOTIA.ESRB = "";
                NOTIA.Price = (double)17.99;
                NOTIA.ReleaseDate = Convert.ToDateTime("21/02/2019");
                NOTIA.Discount = 15;
                NOTIA.DiscountStart = Convert.ToDateTime("3/10/2019");
                NOTIA.DiscountEnd = Convert.ToDateTime("3/10/2019");
                NOTIA.Description =
                        "Noita is a magical action roguelite set in a world where every pixel is physically simulated. Fight, explore, melt, burn, freeze and evaporate your way through the procedurally generated world using spells you've created yourself. Explore a variety of environments ranging from coal mines to freezing wastelands while delving deeper in search for unknown mysteries.";
                NOTIA.NumOfSales = 3260;
                db.Products.Add(NOTIA);

                Product CIVVIDD = new Product();
                CIVVIDD.ProductName = "SID MEIER’S CIVILIZATION® VI - DIGITAL DELUXE";
                CIVVIDD.Genre = "Action, Indie, Adventure, RPG";
                CIVVIDD.Developer = "Nolla Games";
                CIVVIDD.Publisher = "Nolla Games";
                CIVVIDD.Platform = "Steam, Windows";
                CIVVIDD.OperatingSystem = "Windows";
                CIVVIDD.ESRB = "";
                CIVVIDD.Price = (double)17.99;
                CIVVIDD.ReleaseDate = Convert.ToDateTime("26/12/2018");
                CIVVIDD.Discount = 50;
                CIVVIDD.DiscountStart = Convert.ToDateTime("3/10/2019");
                CIVVIDD.DiscountEnd = Convert.ToDateTime("3/10/2019");
                CIVVIDD.Description =
                        "Play as various famous world leaders in this Sid Meier's classic";
                CIVVIDD.NumOfSales = 7352;
                db.Products.Add(CIVVIDD);

                Product INDIVISIBLE = new Product();
                INDIVISIBLE.ProductName = "INDIVISIBLE";
                INDIVISIBLE.Genre = "Action, Indie, Adventure, RPG";
                INDIVISIBLE.Developer = "Lab Zero Games";
                INDIVISIBLE.Publisher = "505 Games";
                INDIVISIBLE.Platform = "Steam, Windows, Mac, Linux";
                INDIVISIBLE.OperatingSystem = "Windows";
                INDIVISIBLE.ESRB = "";
                INDIVISIBLE.Price = (double)35.99;
                INDIVISIBLE.ReleaseDate = Convert.ToDateTime("16/2/2019");
                INDIVISIBLE.Discount = 35;
                INDIVISIBLE.DiscountStart = Convert.ToDateTime("3/10/2019");
                INDIVISIBLE.DiscountEnd = Convert.ToDateTime("3/10/2019");
                INDIVISIBLE.Description =
                        "Preorder Indivisible and receive the following bonuses:Roti,Ajna's loveable pet Tapir, will follow you in game as you quest to save the world of Loka!Additional cosmetic character recolor skins.";
                INDIVISIBLE.NumOfSales = 1833;
                db.Products.Add(INDIVISIBLE);

                Product DIRTRALLy2DE = new Product();
                DIRTRALLy2DE.ProductName = "DIRT RALLY 2.0 DELUXE EDITION";
                DIRTRALLy2DE.Genre = "Racing, Simulation, Sports";
                DIRTRALLy2DE.Developer = "Codemasters";
                DIRTRALLy2DE.Publisher = "Codemasters";
                DIRTRALLy2DE.Platform = "Steam, Windows";
                DIRTRALLy2DE.OperatingSystem = "Windows";
                DIRTRALLy2DE.ESRB = "";
                DIRTRALLy2DE.Price = (double)31.99;
                DIRTRALLy2DE.ReleaseDate = Convert.ToDateTime("15/06/2019");
                DIRTRALLy2DE.Discount = 25;
                DIRTRALLy2DE.DiscountStart = Convert.ToDateTime("3/10/2019");
                DIRTRALLy2DE.DiscountEnd = Convert.ToDateTime("3/10/2019");
                DIRTRALLy2DE.Description =
                "Drive in new cars such as the Austom Martin Prototype in the Deluxe Edition of DIRT Rally";
                DIRTRALLy2DE.NumOfSales = 4562;
                db.Products.Add(DIRTRALLy2DE);

                Product WARSAW = new Product();
                WARSAW.ProductName = "WARSAW";
                WARSAW.Genre = "Indie, RPG, Strategy";
                WARSAW.Developer = "Pixelated Milk";
                WARSAW.Publisher = "gaming company";
                WARSAW.Platform = "Steam, Windows";
                WARSAW.OperatingSystem = "Windows";
                WARSAW.ESRB = "";
                WARSAW.Price = (double)23.99;
                WARSAW.ReleaseDate = Convert.ToDateTime("8/8/2019");
                WARSAW.Discount = 33;
                WARSAW.DiscountStart = Convert.ToDateTime("3/10/2019");
                WARSAW.DiscountEnd = Convert.ToDateTime("3/10/2019");
                WARSAW.Description =
                        "Live the second world war through the eyes of our heroes in this strategy game.";
                WARSAW.NumOfSales = 1230;
                db.Products.Add(WARSAW);

                Product Borderlands2 = new Product();
                Borderlands2.ProductName = "BORDERLANDS 2: GAME OF THE YEAR";
                Borderlands2.Genre = "Action, RPG";
                Borderlands2.Developer = "PGearbox Software";
                Borderlands2.Publisher = "2K, Aspyr (Mac, Linux)";
                Borderlands2.Platform = "Steam, Windows, Linux";
                Borderlands2.OperatingSystem = "Windows";
                Borderlands2.ESRB = "M17+";
                Borderlands2.Price = (double)8.79;
                Borderlands2.ReleaseDate = Convert.ToDateTime("6/6/2017");
                Borderlands2.Discount = 20;
                Borderlands2.DiscountStart = Convert.ToDateTime("3/10/2019");
                Borderlands2.DiscountEnd = Convert.ToDateTime("3/10/2019");
                Borderlands2.Description =
                        "Summary A new era of shoot and loot is about to begin. Play as one of four new vault hunters facing off against a massive new world of creatures, psychos and the evil mastermind, Handsome Jack. Make new friends, arm them with a bazillion weapons and fight alongside them in 4 player co-op on a relentless quest for revenge and redemption across the undiscovered and unpredictable living planet.";
                Borderlands2.NumOfSales = 9923;
                db.Products.Add(Borderlands2);

                Product CONTROL = new Product();
                CONTROL.ProductName = "CONTROL";
                CONTROL.Genre = "Action, Adventure";
                CONTROL.Developer = "Remedy Entertainment";
                CONTROL.Publisher = "505 Games";
                CONTROL.Platform = "Epic Games Store, Windows";
                CONTROL.OperatingSystem = "Windows";
                CONTROL.ESRB = "M17+";
                CONTROL.Price = (double)59.99;
                CONTROL.ReleaseDate = Convert.ToDateTime("15/9/2019");
                CONTROL.Discount = 0;
                CONTROL.DiscountStart = Convert.ToDateTime("3/10/2019");
                CONTROL.DiscountEnd = Convert.ToDateTime("3/10/2019");
                CONTROL.Description =
                        "After a secretive agency in New York is invaded by an otherworldly threat, you become the new Director struggling to regain Control.";
                CONTROL.NumOfSales = 4422;
                db.Products.Add(CONTROL);

                Product CRYINGSUNS = new Product();
                CRYINGSUNS.ProductName = "CRYING SUNS";
                CRYINGSUNS.Genre = "Indie, Strategy";
                CRYINGSUNS.Developer = "Alt Shift";
                CRYINGSUNS.Publisher = "Humble Bundle";
                CRYINGSUNS.Platform = "Epic Games Store, Windows";
                CRYINGSUNS.OperatingSystem = "Windows, Mac";
                CRYINGSUNS.ESRB = "";
                CRYINGSUNS.Price = (double)24.99;
                CRYINGSUNS.ReleaseDate = Convert.ToDateTime("16/1/2019");
                CRYINGSUNS.Discount = 0;
                CRYINGSUNS.DiscountStart = Convert.ToDateTime("3/10/2019");
                CRYINGSUNS.DiscountEnd = Convert.ToDateTime("3/10/2019");
                CRYINGSUNS.Description =
                        "Crying Suns is a tactical rogue-lite that puts you in the role of a space fleet commander as you explore a mysteriously fallen empire.";
                CRYINGSUNS.NumOfSales = 1232;
                db.Products.Add(CRYINGSUNS);

                Product RISKOFRAIN2 = new Product();
                RISKOFRAIN2.ProductName = "RISK OF RAIN 2";
                RISKOFRAIN2.Genre = "Action, Indie";
                RISKOFRAIN2.Developer = "Hopoo Games";
                RISKOFRAIN2.Publisher = "Gearbox Publishing";
                RISKOFRAIN2.Platform = "Steam, Windows";
                RISKOFRAIN2.OperatingSystem = "Windows";
                RISKOFRAIN2.ESRB = "";
                RISKOFRAIN2.Price = (double)19.99;
                RISKOFRAIN2.ReleaseDate = Convert.ToDateTime("14/4/2019");
                RISKOFRAIN2.Discount = 20;
                RISKOFRAIN2.DiscountStart = Convert.ToDateTime("3/10/2019");
                RISKOFRAIN2.DiscountEnd = Convert.ToDateTime("3/10/2019");
                RISKOFRAIN2.Description =
                        "The classic multiplayer roguelike, Risk of Rain, returns with an extra dimension and more challenging action. No run will ever be the same with randomized stages, enemies, bosses, and items. Play solo, or team up with up to four friends to fight your way through hordes of monsters, unlock new loot, and find a way to escape the planet.";
                RISKOFRAIN2.NumOfSales = 1541;
                db.Products.Add(RISKOFRAIN2);

                Product NINOKUNIWOWW = new Product();
                NINOKUNIWOWW.ProductName = "NI NO KUNI: WRATH OF THE WHITE WITCH™ REMASTERED";
                NINOKUNIWOWW.Genre = "Adventure, RPG";
                NINOKUNIWOWW.Developer = "Level-5";
                NINOKUNIWOWW.Publisher = "BANDAI NAMCO Entertainment";
                NINOKUNIWOWW.Platform = "Steam, Windows";
                NINOKUNIWOWW.OperatingSystem = "Windows";
                NINOKUNIWOWW.ESRB = "";
                NINOKUNIWOWW.Price = (double)49.99;
                NINOKUNIWOWW.ReleaseDate = Convert.ToDateTime("27/8/2019");
                NINOKUNIWOWW.Discount = 0;
                NINOKUNIWOWW.DiscountStart = Convert.ToDateTime("3/10/2019");
                NINOKUNIWOWW.DiscountEnd = Convert.ToDateTime("3/10/2019");
                NINOKUNIWOWW.Description =
                        "Journey back to the other world in Ni no Kuni: Wrath of the White Witch™ Remastered. LEVEL-5’s classic tale returns better than ever, with improved graphics and performance. Join Oliver as he embarks on an adventure through a world inhabited by new friends and ferocious foes alike in the hopes of bringing back his mother after a tragic incident.";
                NINOKUNIWOWW.NumOfSales = 2928;
                db.Products.Add(NINOKUNIWOWW);

                Product GRIDUE = new Product();
                GRIDUE.ProductName = "GRID™ - ULTIMATE EDITION";
                GRIDUE.Genre = "Action, Sports, Racing, Simulation";
                GRIDUE.Developer = "Codemasters";
                GRIDUE.Publisher = "Codemasters";
                GRIDUE.Platform = "Steam, Windows";
                GRIDUE.OperatingSystem = "Windows";
                GRIDUE.ESRB = "";
                GRIDUE.Price = (double)79.99;
                GRIDUE.ReleaseDate = Convert.ToDateTime("8/11/2018");
                GRIDUE.Discount = 0;
                GRIDUE.DiscountStart = Convert.ToDateTime("3/10/2019");
                GRIDUE.DiscountEnd = Convert.ToDateTime("3/10/2019");
                GRIDUE.Description =
                        "GRID is a racing experience like no other. Offering unrivalled moment-to-moment racing, GRID returns with an all-new experience where every race is the chance to choose your own path, create your own story and conquer the world of motorsport";
                GRIDUE.NumOfSales = 2121;
                db.Products.Add(GRIDUE);


                Product TROPICO6 = new Product();
                TROPICO6.ProductName = "TROPICO 6";
                TROPICO6.Genre = "Simulation" + "Strategy";
                TROPICO6.Developer = "Limbic Entertainment";
                TROPICO6.Publisher = "Kalypso Media";
                TROPICO6.Platform = "Steam" + "Windows" + "Mac" + "Linux";
                TROPICO6.OperatingSystem = "Windows" + "Mac" + "Linux";
                TROPICO6.ESRB = "";
                TROPICO6.Price = (double)39.99;
                TROPICO6.ReleaseDate = Convert.ToDateTime("3/10/2018");
                TROPICO6.Discount = 50;
                TROPICO6.DiscountStart = Convert.ToDateTime("3/10/2019");
                TROPICO6.DiscountEnd = Convert.ToDateTime("3/10/2019");
                TROPICO6.DiscountStart = Convert.ToDateTime("3/10/2019");
                TROPICO6.Description =
                    "Play on large archipelagos for the first time in the series. Manage multiple islands at the same time and adapt to various new challenges.";
                TROPICO6.NumOfSales = 5222;
                db.Products.Add(TROPICO6);

                Product GTAV = new Product();
                GTAV.ProductName = "GRAND THEFT AUTO V";
                GTAV.Genre = "Action";
                GTAV.Developer = "Rockstar North";
                GTAV.Publisher = "Rockstar Games";
                GTAV.Platform = "Steam";
                GTAV.OperatingSystem = "Windows";
                GTAV.ESRB = "";
                GTAV.Price = (double)29.99;
                GTAV.ReleaseDate = Convert.ToDateTime("3/10/2015");
                GTAV.Discount = 15;
                GTAV.DiscountStart = Convert.ToDateTime("3/10/2019");
                GTAV.DiscountEnd = Convert.ToDateTime("3/10/2019");
                GTAV.Description =
                    "Play on large archipelagos for the first time in the series. Manage multiple islands at the same time and adapt to various new challenges.";
                GTAV.NumOfSales = 13777;
                db.Products.Add(GTAV);

                Product WWZ = new Product();
                WWZ.ProductName = "WORLD WAR Z";
                WWZ.Genre = "Action";
                WWZ.Developer = "Saber Interactive";
                WWZ.Publisher = "Saber Interactive";
                WWZ.Platform = "Windows";
                WWZ.OperatingSystem = "Windows";
                WWZ.ESRB = "";
                WWZ.Price = (double)34.99;
                WWZ.ReleaseDate = Convert.ToDateTime("3/10/2019");
                WWZ.Discount = 10;
                WWZ.DiscountStart = Convert.ToDateTime("3/10/2019");
                WWZ.DiscountEnd = Convert.ToDateTime("3/10/2019");
                WWZ.Description =
                    "World War Z is a heart-pounding four-player cooperative third-person shooter featuring massive swarms of zombies that recklessly rush their living prey.";
                WWZ.NumOfSales = 6372;
                db.Products.Add(WWZ);

                Product blairWitch = new Product();
                blairWitch.ProductName = "BLAIR WITCH";
                blairWitch.Genre = "Indie" + "Adventure";
                blairWitch.Developer = "Bloober Team";
                blairWitch.Publisher = "Bloober Team NA";
                blairWitch.Platform = "Steam" + "Windows";
                blairWitch.OperatingSystem = "Windows";
                blairWitch.ESRB = "";
                blairWitch.Price = (double)29.99;
                blairWitch.ReleaseDate = Convert.ToDateTime("3/03/2019");
                blairWitch.Discount = 0;
                blairWitch.DiscountStart = Convert.ToDateTime("3/10/2019");
                blairWitch.DiscountEnd = Convert.ToDateTime("3/10/2019");
                blairWitch.Description =
                    "Your darkest fears will awaken in these woods.";
                blairWitch.NumOfSales = 1239;
                db.Products.Add(blairWitch);

                Product astroneer = new Product();
                astroneer.ProductName = "ASTRONEER";
                astroneer.Genre = "Adventure" + "Indie";
                astroneer.Developer = "System Era Softworks";
                astroneer.Publisher = "System Era Softworks";
                astroneer.Platform = "Steam" + "Windows";
                astroneer.OperatingSystem = "Windows";
                astroneer.ESRB = "";
                astroneer.Price = (double)29.99;
                astroneer.ReleaseDate = Convert.ToDateTime("3/10/2019");
                astroneer.Discount = 10;
                astroneer.DiscountStart = Convert.ToDateTime("3/10/2019");
                astroneer.DiscountEnd = Convert.ToDateTime("3/10/2019");
                astroneer.Description =
                    "Explore and reshape distant worlds! Astroneer is set during the 25th century Intergalactic Age of Discovery, where Astroneers explore the frontiers of outer space, risking their lives in harsh environments to unearth rare discoveries and unlock the mysteries of the universe.";
                astroneer.NumOfSales = 999;
                db.Products.Add(astroneer);

                Product ACODYSSEY = new Product();
                ACODYSSEY.ProductName = "ASSASSIN'S CREED ODYSSEY";
                ACODYSSEY.Genre = "Action, Adventure, RPG";
                ACODYSSEY.Developer = "BANDAI NAMCO Studios Inc.";
                ACODYSSEY.Publisher = "BANDAI NAMCO Entertainment";
                ACODYSSEY.Platform = "Steam" + "Windows";
                ACODYSSEY.OperatingSystem = "Windows";
                ACODYSSEY.ESRB = "";
                ACODYSSEY.Price = (double)59.99;
                ACODYSSEY.ReleaseDate = Convert.ToDateTime("3/10/2018");
                ACODYSSEY.Discount = 33;
                ACODYSSEY.DiscountStart = Convert.ToDateTime("3/10/2019");
                ACODYSSEY.DiscountEnd = Convert.ToDateTime("3/10/2019");
                ACODYSSEY.Description =
                        "Choose your fate in Assassin's Creed® Odyssey. ";
                ACODYSSEY.NumOfSales = 6897;
                db.Products.Add(ACODYSSEY);

                Product DMC5 = new Product();
                DMC5.ProductName = "DEVIL MAY CRY 5";
                DMC5.Genre = "Action";
                DMC5.Developer = "CAPCOM Co., Ltd.";
                DMC5.Publisher = "CAPCOM Co., Ltd.";
                DMC5.Platform = "Steam, Windows";
                DMC5.OperatingSystem = "Windows";
                DMC5.ESRB = "";
                DMC5.Price = (double)59.99;
                DMC5.ReleaseDate = Convert.ToDateTime("24/5/2019");
                DMC5.Discount = 17;
                DMC5.DiscountStart = Convert.ToDateTime("3/10/2019");
                DMC5.DiscountEnd = Convert.ToDateTime("3/10/2019");
                DMC5.Description =
                        "The threat of demonic power has returned to menace the world once again in Devil May Cry 5.";
                DMC5.NumOfSales = 9999;
                db.Products.Add(DMC5);

                Product DIRT4 = new Product();
                DIRT4.ProductName = "DIRT 4";
                DIRT4.Genre = "Racing, Simulation, Sports";
                DIRT4.Developer = "Codemasters, Feral Interactive (Mac & Linux)";
                DIRT4.Publisher = "Codemasters, Feral Interactive (Mac & Linux)";
                DIRT4.Platform = "Steam, Windows, Mac";
                DIRT4.OperatingSystem = "Windows, Mac";
                DIRT4.ESRB = "";
                DIRT4.Price = (double)59.99;
                DIRT4.ReleaseDate = Convert.ToDateTime("9/9/2019");
                DIRT4.Discount = 0;
                DIRT4.DiscountStart = Convert.ToDateTime("3/10/2019");
                DIRT4.DiscountEnd = Convert.ToDateTime("3/10/2019");
                DIRT4.Description =
                        "The world’s leading off-road racing series is back!";
                DIRT4.NumOfSales = 8888;
                db.Products.Add(DIRT4);

                Product TOW = new Product();
                TOW.ProductName = "THE OUTER WORLDS";
                TOW.Genre = "RPG";
                TOW.Developer = "Obsidian Entertainment";
                TOW.Publisher = "Private Division";
                TOW.Platform = "Steam, Windows";
                TOW.OperatingSystem = "Windows";
                TOW.ESRB = "M17+";
                TOW.Price = (double)59.99;
                TOW.ReleaseDate = Convert.ToDateTime("11/8/2019");
                TOW.Discount = 15;
                TOW.DiscountStart = Convert.ToDateTime("3/10/2019");
                TOW.DiscountEnd = Convert.ToDateTime("3/10/2019");
                TOW.Description = "Explore the unique world in this RPG1";
                TOW.NumOfSales = 7777;
                db.Products.Add(TOW);

                Product STARBOUND = new Product();
                STARBOUND.ProductName = "STARBOUND";
                STARBOUND.Genre = "Indie, Adventure";
                STARBOUND.Developer = "Chucklefish";
                STARBOUND.Publisher = "Chucklefish";
                STARBOUND.Platform = "Steam, Windows, Mac";
                STARBOUND.OperatingSystem = "Windows, Mac";
                STARBOUND.ESRB = "";
                STARBOUND.Price = (double)14.99;
                STARBOUND.ReleaseDate = Convert.ToDateTime("7/7/2019");
                STARBOUND.Discount = 0;
                STARBOUND.DiscountStart = Convert.ToDateTime("3/10/2019");
                STARBOUND.DiscountEnd = Convert.ToDateTime("3/10/2019");
                STARBOUND.Description =
                    "In Starbound, you create your own story.";
                STARBOUND.NumOfSales = 6666;
                db.Products.Add(STARBOUND);

                Product NOMANSSKY = new Product();
                NOMANSSKY.ProductName = "NO MAN'S SKY";
                NOMANSSKY.Genre = "Indie, Action, Adventure";
                NOMANSSKY.Developer = "Chucklefish";
                NOMANSSKY.Publisher = "Chucklefish";
                NOMANSSKY.Platform = "Steam, Windows";
                NOMANSSKY.OperatingSystem = "Windows";
                NOMANSSKY.ESRB = "";
                NOMANSSKY.Price = (double)59.99;
                NOMANSSKY.ReleaseDate = Convert.ToDateTime("3/10/2016");
                NOMANSSKY.Discount = 70;
                NOMANSSKY.DiscountStart = Convert.ToDateTime("3/10/2019");
                NOMANSSKY.DiscountEnd = Convert.ToDateTime("3/10/2019");
                NOMANSSKY.Description =
                    "Inspired by the adventure and imagination that we love from classic science-fiction.";
                NOMANSSKY.NumOfSales = 5555;
                db.Products.Add(NOMANSSKY);

                Product MAGICKA2 = new Product();
                MAGICKA2.ProductName = "MAGICKA 2";
                MAGICKA2.Genre = "Action, RPG";
                MAGICKA2.Developer = "Pieces Interactive";
                MAGICKA2.Publisher = "Paradox Interactive";
                MAGICKA2.Platform = "Steam, Windows";
                MAGICKA2.OperatingSystem = "Windows";
                MAGICKA2.ESRB = "";
                MAGICKA2.Price = (double)6.99;
                MAGICKA2.ReleaseDate = Convert.ToDateTime("3/10/2015");
                MAGICKA2.Discount = 55;
                MAGICKA2.DiscountStart = Convert.ToDateTime("3/10/2019");
                MAGICKA2.DiscountEnd = Convert.ToDateTime("3/10/2019");
                MAGICKA2.Description =
                    "The world’s most irreverent co-op action adventure returns!";
                MAGICKA2.NumOfSales = 2323;
                db.Products.Add(MAGICKA2);


                //01 Customer
                Customer Customer1 = new Customer();
                Customer1.FirstName = "Kelly";
                Customer1.LastName = "Sanford";
                Customer1.Username = "kellysanford";
                Customer1.Password = CreatePasswordSalt("team62");
                Customer1.Email = Customer1.Username + "@gmail.com";
                Customer1.Phone = "65-85554433";
                Customer1.BirthDate = Convert.ToDateTime("10/10/1992");
                db.Customers.Add(Customer1);


                //02 Customer
                Customer Customer2 = new Customer();
                Customer2.FirstName = "Augustine";
                Customer2.LastName = "Mann";
                Customer2.Username = "augustinemann";
                Customer2.Password = CreatePasswordSalt("team62");
                Customer2.Email = Customer2.Username + "@gmail.com";
                Customer2.Phone = "65-95557373 ";
                Customer2.BirthDate = Convert.ToDateTime("1/5/ 1992");
                db.Customers.Add(Customer2);


                //03 Customer
                Customer Customer3 = new Customer();
                Customer3.FirstName = "Kaylah";
                Customer3.LastName = "Bergnaum";
                Customer3.Username = "kaylahbergnaum";
                Customer3.Password = CreatePasswordSalt("team62");
                Customer3.Email = Customer3.Username + "@gmail.com";
                Customer3.Phone = "65-95556097";
                Customer3.BirthDate = Convert.ToDateTime("2 / 8 / 1984");
                db.Customers.Add(Customer3);

                //04 Customer
                Customer Customer4 = new Customer();
                Customer4.FirstName = "Yibo";
                Customer4.LastName = "Wang";
                Customer4.Username = "wangyibo";
                Customer4.Password = CreatePasswordSalt("team62");
                Customer4.Email = Customer4.Username + "@gmail.com";
                Customer4.Phone = "65-85557673";
                Customer4.BirthDate = Convert.ToDateTime("6/ 3 / 1995");
                db.Customers.Add(Customer4);

                //05 Customer
                Customer Customer5 = new Customer();
                Customer5.FirstName = "Josianne";
                Customer5.LastName = "Boehm";
                Customer5.Username = "josianneboehm";
                Customer5.Password = CreatePasswordSalt("team62");
                Customer5.Email = Customer5.Username + "@gmail.com";
                Customer5.Phone = "65-85553205";
                Customer5.BirthDate = Convert.ToDateTime("4 / 3 / 1993");
                db.Customers.Add(Customer5);

                //06 Customer
                Customer Customer6 = new Customer();
                Customer6.FirstName = "Kylie";
                Customer6.LastName = "Jenner";
                Customer6.Username = "kyliejenner";
                Customer6.Password = CreatePasswordSalt("team62");
                Customer6.Email = Customer6.Username + "@gmail.com";
                Customer6.Phone = "65-95552318";
                Customer6.BirthDate = Convert.ToDateTime("23 / 8/ 1990");
                db.Customers.Add(Customer6);

                //07 Customer
                Customer Customer7 = new Customer();
                Customer7.FirstName = "Kendall";
                Customer7.LastName = "Jenner";
                Customer7.Username = "kendalljenner";
                Customer7.Password = CreatePasswordSalt("team62");
                Customer7.Email = Customer7.Username + "@gmail.com";
                Customer7.Phone = "65-95553041";
                Customer7.BirthDate = Convert.ToDateTime("6/ 11/ 1990");
                db.Customers.Add(Customer7);

                //08 Customer
                Customer Customer8 = new Customer();
                Customer8.FirstName = "Jade";
                Customer8.LastName = "Weimann";
                Customer8.Username = "jadeweimann";
                Customer8.Password = CreatePasswordSalt("team62");
                Customer8.Email = Customer8.Username + "@gmail.com";
                Customer8.Phone = "65-95553041";
                Customer8.BirthDate = Convert.ToDateTime("4 / 3 / 1989");
                db.Customers.Add(Customer8);

                //09 Customer
                Customer Customer9 = new Customer();
                Customer9.FirstName = "Odell";
                Customer9.LastName = "Gerhold";
                Customer9.Username = "odellgerhold";
                Customer9.Password = CreatePasswordSalt("team62");
                Customer9.Email = Customer9.Username + "@gmail.com";
                Customer9.Phone = "65-9555910";
                Customer9.BirthDate = Convert.ToDateTime("2 / 7 / 2006");
                db.Customers.Add(Customer9);

                //10 Customer
                Customer Customer10 = new Customer();
                Customer10.FirstName = "Rafael";
                Customer10.LastName = "Bogan";
                Customer10.Username = "rafaelbogan";
                Customer10.Password = CreatePasswordSalt("team62");
                Customer10.Email = Customer10.Username + "@gmail.com";
                Customer10.Phone = "65-95556346 ";
                Customer10.BirthDate = Convert.ToDateTime("6 / 1 / 1980");
                db.Customers.Add(Customer10);

                db.SaveChanges();
            }
        }

        static void Seed2()
        {
            using (var db = new Model1Container())
            {

                Image borderlands3Image = new Image();
                borderlands3Image.ImageName = "BORDERLANDS 3";
                borderlands3Image.ImageUrl =
                    "https://hb.imgix.net/ed7fd04016922b01ae7c0fd3a8eb2719c3152c72.jpg?auto=compress,format&fit=crop&h=353&w=616&s=4b27683de483863229598dcfbb455b22";
                borderlands3Image.ImageType = "jpeg";
                borderlands3Image.ProductId = 1;
                db.Images.Add(borderlands3Image);

                Image Destiny2SDDEImage = new Image();
                Destiny2SDDEImage.ImageName = "DESTINY 2: SHADOWKEEP DIGITAL DELUXE EDITION";
                Destiny2SDDEImage.ImageUrl = "https://hb.imgix.net/8aea6d3999d18e50fe86a36f2667aa206449c6c2.jpg?auto=compress,format&fit=crop&h=353&w=616&s=7b298635face6ccdea2a0b5a3d1a9fae";
                Destiny2SDDEImage.ImageType = "jpeg";
                Destiny2SDDEImage.ProductId = 2;
                db.Images.Add(Destiny2SDDEImage);

                //03  Image
                Image Destiny2sImage = new Image();
                Destiny2sImage.ImageName = "DESTINY 2: SHADOWKEEP";
                Destiny2sImage.ImageUrl = "https://hb.imgix.net/30dd477a168d494403e0e0bfc31f55fa78c976a4.jpg?auto=compress,format&fit=crop&h=353&w=616&s=3e7d63aa267ee0d8cf80ead275e4ccd7 ";
                Destiny2sImage.ImageType = "jpeg";
                Destiny2sImage.ProductId = 3;
                db.Images.Add(Destiny2sImage);

                //04  Image
                Image codeVeinImage = new Image();
                codeVeinImage.ImageName = "CODE VEIN";
                codeVeinImage.ImageUrl = "https://hb.imgix.net/8c67110933ce17bb89517956eb6f93a2ec0d03e1.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=aeb8c84cc0ef2a8124a8b21ff6ee2b04";
                codeVeinImage.ImageType = "jpeg";
                codeVeinImage.ProductId = 4;
                db.Images.Add(codeVeinImage);

                //05  Image
                Image CODBlackOpImages = new Image();
                CODBlackOpImages.ImageName = "CALL OF DUTY®: BLACK OPS III - ZOMBIES DELUXE";
                CODBlackOpImages.ImageUrl = "https://hb.imgix.net/ee50bfefe41f352f94dbc5777f4f1ad29e81e608.jpg?auto=compress,format&fit=crop&h=353&w=616&s=13fd82f00ab5bef6173ce84aaa9fc113";
                CODBlackOpImages.ImageType = "jpeg";
                CODBlackOpImages.ProductId = 5;
                db.Images.Add(CODBlackOpImages);

                //06  Image
                Image XCOMCollectionImage = new Image();
                XCOMCollectionImage.ImageName = "XCOM® 2 COLLECTION";
                XCOMCollectionImage.ImageUrl = "https://hb.imgix.net/9e82bbd5617f3fe382e2649c3b83e81cc2f71e67.jpg?auto=compress,format&fit=crop&h=353&w=616&s=54cd9b0e60550c098e7267ec394c6f05";
                XCOMCollectionImage.ImageType = "jpeg";
                XCOMCollectionImage.ProductId = 6;
                db.Images.Add(XCOMCollectionImage);

                //07  Image
                Image NOITAImage = new Image();
                NOITAImage.ImageName = "NOITAImage";
                NOITAImage.ImageUrl = "https://hb.imgix.net/3fac400b07fd40a27dfd3a91cacc73f44580197f.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=f119fe4e2e1f0239aba5afb7f358d2d4";
                NOITAImage.ImageType = "jpeg";
                NOITAImage.ProductId = 7;
                db.Images.Add(NOITAImage);


                //08  Image
                Image CIVVIDDImage = new Image();
                CIVVIDDImage.ImageName = "SID MEIER’S CIVILIZATION® VI - DIGITAL DELUXE";
                CIVVIDDImage.ImageUrl = "https://hb.imgix.net/640ede1922e9a5c640cb3a976405217e779f77bb.jpg?auto=compress,format&fit=crop&h=353&w=616&s=6508c1eff78f9705a206efe5486b397a";
                CIVVIDDImage.ImageType = "jpeg";
                CIVVIDDImage.ProductId = 8;
                db.Images.Add(CIVVIDDImage);


                //09  Image
                Image INDIVISIBLEImage = new Image();
                INDIVISIBLEImage.ImageName = "INDIVISIBLEImage";
                INDIVISIBLEImage.ImageUrl = "https://hb.imgix.net/cfa9f516c876a5a2b9d875101fa05e3f90f3343e.jpg?auto=compress,format&fit=crop&h=353&w=616&s=acc938d3c53fd54890d13ffcd37975c4";
                INDIVISIBLEImage.ImageType = "jpeg";
                INDIVISIBLEImage.ProductId = 9;
                db.Images.Add(INDIVISIBLEImage);


                //10  Image
                Image DIRTRALLy2DEImage = new Image();
                DIRTRALLy2DEImage.ImageName = "DIRT RALLY 2.0 DELUXE EDITION";
                DIRTRALLy2DEImage.ImageUrl = "https://hb.imgix.net/c49655819161eed108ebbb8365b6a3f58e20f796.jpg?auto=compress,format&fit=crop&h=353&w=616&s=d0c3fe317fbb7fee4610de0682fec2fe";
                DIRTRALLy2DEImage.ImageType = "jpeg";
                DIRTRALLy2DEImage.ProductId = 10;
                db.Images.Add(DIRTRALLy2DEImage);


                //11  Image
                Image WARSAWImage = new Image();
                WARSAWImage.ImageName = "WARSAW";
                WARSAWImage.ImageUrl = "https://hb.imgix.net/72c6a5acf3af8c97f813ccac84551e0d3b33d0a3.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=79185a632ef4da65aa691bda7e771ca3";
                WARSAWImage.ImageType = "jpeg";
                WARSAWImage.ProductId = 11;
                db.Images.Add(WARSAWImage);


                //12  Image
                Image Borderlands2Image = new Image();
                Borderlands2Image.ImageName = "BORDERLANDS 2: GAME OF THE YEAR";
                Borderlands2Image.ImageUrl = "https://hb.imgix.net/14ed9ec621e0360f5c30e39494b8da6b7cb67594.jpg?auto=compress,format&fit=crop&h=353&w=616&s=62948e8ad1f9f72f77c9538b49251586";
                Borderlands2Image.ImageType = "jpeg";
                Borderlands2Image.ProductId = 12;
                db.Images.Add(Borderlands2Image);


                //13  Image
                Image CONTROLImage = new Image();
                CONTROLImage.ImageName = "CONTROLImage";
                CONTROLImage.ImageUrl = "https://hb.imgix.net/3b3d52c2d3564e5514081735a6117b9670b163f0.jpg?auto=compress,format&fit=crop&h=353&w=616&s=b4408196da2530cf2215528661c744dc";
                CONTROLImage.ImageType = "jpeg";
                CONTROLImage.ProductId = 13;
                db.Images.Add(CONTROLImage);


                //14  Image
                Image CRYINGSUNSImage = new Image();
                CRYINGSUNSImage.ImageName = "CRYING SUNS";
                CRYINGSUNSImage.ImageUrl = "https://hb.imgix.net/2e18a2a9316c0136abf25670bf67ed389c855e4f.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=d50b680a5bfd2c6c6acdb4c745db8428";
                CRYINGSUNSImage.ImageType = "jpeg";
                CRYINGSUNSImage.ProductId = 14;
                db.Images.Add(CRYINGSUNSImage);


                //15  Image
                Image RISKOFRAIN2Image = new Image();
                RISKOFRAIN2Image.ImageName = "RISK OF RAIN 2";
                RISKOFRAIN2Image.ImageUrl = "https://hb.imgix.net/7af7de843f8a048e06f66d76dabfd1a3a093286e.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=ef9ff383dabd50935360cde70a4a5ac7";
                RISKOFRAIN2Image.ImageType = "jpeg";
                RISKOFRAIN2Image.ProductId = 15;
                db.Images.Add(RISKOFRAIN2Image);


                //16  Image
                Image NINOKUNIWOWWImage = new Image();
                NINOKUNIWOWWImage.ImageName = "NI NO KUNI: WRATH OF THE WHITE WITCH™ REMASTERED";
                NINOKUNIWOWWImage.ImageUrl = "https://hb.imgix.net/0eed70780c05089bd68ce8d500fcfae4c85bd92c.jpg?auto=compress,format&fit=crop&h=353&w=616&s=1daaef9af39e53d97b900b63befb3115";
                NINOKUNIWOWWImage.ImageType = "jpeg";
                NINOKUNIWOWWImage.ProductId = 16;
                db.Images.Add(NINOKUNIWOWWImage);


                //17  Image
                Image GRIDUEImage = new Image();
                GRIDUEImage.ImageName = "GRID™ - ULTIMATE EDITION";
                GRIDUEImage.ImageUrl = "https://hb.imgix.net/cb0f6e2357d058df69f20f72749467d56c78fced.jpg?auto=compress,format&fit=crop&h=353&w=616&s=9ab9c7f5f31715a0cbb2426418ace6f1";
                GRIDUEImage.ImageType = "jpeg";
                GRIDUEImage.ProductId = 17;
                db.Images.Add(GRIDUEImage);


                //18  Image
                Image TROPICO6Image = new Image();
                TROPICO6Image.ImageName = "TROPICO 6";
                TROPICO6Image.ImageUrl = "https://hb.imgix.net/d8fabc189c5a7bcc374eb88bf4b68deb0511090e.jpg?auto=compress,format&fit=crop&h=353&w=616&s=c6fd4bf49808ed295ab152d4e50e6eee";
                TROPICO6Image.ImageType = "jpeg";
                TROPICO6Image.ProductId = 18;
                db.Images.Add(TROPICO6Image);


                //19  Image
                Image GTAVImage = new Image();
                GTAVImage.ImageName = "GRAND THEFT AUTO V";
                GTAVImage.ImageUrl = "https://hb.imgix.net/ad3f96dfd21531e24ab72c3821a01049c8484982.jpg?auto=compress,format&fit=crop&h=353&w=616&s=9fc123b4c723d329d164b8ab02af5284";
                GTAVImage.ImageType = "jpeg";
                GTAVImage.ProductId = 19;
                db.Images.Add(GTAVImage);


                //20  Image
                Image WWZImage = new Image();
                WWZImage.ImageName = "WORLD WAR Z";
                WWZImage.ImageUrl = "https://hb.imgix.net/2a5891dfd635d976f534037c037daad99ed3cf74.jpg?auto=compress,format&fit=crop&h=353&w=616&s=c5f4569fce7e5b3a5aafa8663528875a";
                WWZImage.ImageType = "jpeg";
                WWZImage.ProductId = 20;
                db.Images.Add(WWZImage);


                //21  Image
                Image blairWitchImage = new Image();
                blairWitchImage.ImageName = "BLAIR WITCH";
                blairWitchImage.ImageUrl = "https://hb.imgix.net/d1129f0f4ca1401e1af87dd7ccc31dc896857558.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=22e89ec042ae733297807ba9e9341ec7";
                blairWitchImage.ImageType = "jpeg";
                blairWitchImage.ProductId = 21;
                db.Images.Add(blairWitchImage);


                //22  Image
                Image astroneerImage = new Image();
                astroneerImage.ImageName = "astroneerImage";
                astroneerImage.ImageUrl = "https://hb.imgix.net/f586084149dd0c6c0ae8885e324c1abe4549f892.jpg?auto=compress,format&fit=crop&h=353&w=616&s=33e59db7adabde3256c7bdb8aff6896c";
                astroneerImage.ImageType = "jpeg";
                astroneerImage.ProductId = 22;
                db.Images.Add(astroneerImage);

                //24  Image
                Image ACODYSSEYImage = new Image();
                ACODYSSEYImage.ImageName = "ASSASSIN'S CREED ODYSSEY";
                ACODYSSEYImage.ImageUrl = "https://hb.imgix.net/74e8d7c2ec7dde490abf64d54f9828fa073ae4e3.jpg?auto=compress,format&fit=crop&h=353&w=616&s=6b9af392df9564413a51c35a14a3c6d1";
                ACODYSSEYImage.ImageType = "jpeg";
                ACODYSSEYImage.ProductId = 23;
                db.Images.Add(ACODYSSEYImage);


                //25  Image
                Image DMC5Image = new Image();
                DMC5Image.ImageName = "DEVIL MAY CRY 5";
                DMC5Image.ImageUrl = "https://hb.imgix.net/73b854a6c097c499edebf21702498686a2c2c219.jpeg?auto=compress,format&fit=crop&h=353&w=616&s=128134e324ec8dca30e186c11cd89915";
                DMC5Image.ImageType = "jpeg";
                DMC5Image.ProductId = 24;
                db.Images.Add(DMC5Image);


                //26  Image
                Image DIRT4Image = new Image();
                DIRT4Image.ImageName = "DIRT4Image";
                DIRT4Image.ImageUrl = "https://hb.imgix.net/f764dafdbcb5c8b7e2032a685ebe7c58ce49884e.jpg?auto=compress,format&fit=crop&h=353&w=616&s=38054e51799ade72c6a7a1d0eebadbb6";
                DIRT4Image.ImageType = "jpeg";
                DIRT4Image.ProductId = 25;
                db.Images.Add(DIRT4Image);


                //27  Image
                Image TOWImage = new Image();
                TOWImage.ImageName = "THE OUTER WORLDS";
                TOWImage.ImageUrl = "https://hb.imgix.net/1e53c73e55d8bb8f174d6f5b229833abf0d67c4c.jpg?auto=compress,format&fit=crop&h=353&w=616&s=7f902d23f18871d472731e4124d32b17";
                TOWImage.ImageType = "jpeg";
                TOWImage.ProductId = 26;
                db.Images.Add(TOWImage);


                //28  Image
                Image STARBOUNDImage = new Image();
                STARBOUNDImage.ImageName = "STARBOUNDImage";
                STARBOUNDImage.ImageUrl = "https://hb.imgix.net/193a427183b130a1f550eb993be5fcc4138569a2.jpg?auto=compress,format&fit=crop&h=353&w=616&s=dce5f2ba0fd651daadfc838c8688d1e9";
                STARBOUNDImage.ImageType = "jpeg";
                STARBOUNDImage.ProductId = 27;
                db.Images.Add(STARBOUNDImage);


                //29  Image
                Image NOMANSSKYImage = new Image();
                NOMANSSKYImage.ImageName = "NO MAN'S SKY";
                NOMANSSKYImage.ImageUrl = "https://hb.imgix.net/137f28767d56538d52d422a60af8772e25e6a786.jpg?auto=compress,format&fit=crop&h=353&w=616&s=8beb86384e94b86d18fa25c662f822f8";
                NOMANSSKYImage.ImageType = "jpeg";
                NOMANSSKYImage.ProductId = 28;
                db.Images.Add(NOMANSSKYImage);


                //30  Image
                Image MAGICKA2Image = new Image();
                MAGICKA2Image.ImageName = "MAGICKA 2";
                MAGICKA2Image.ImageUrl = "https://hb.imgix.net/2d1f395e6f254d31f5c09a6fa5ed11ed7e8fd81a.jpg?auto=compress,format&fit=crop&h=353&w=616&s=5d1f625977638507e7b74764a5376a17";
                MAGICKA2Image.ImageType = "jpeg";
                MAGICKA2Image.ProductId = 29;
                db.Images.Add(MAGICKA2Image);

                db.SaveChanges();
            }
        }

        private const int SALT_SIZE = 8;
        private const int NUM_ITERATIONS = 1000;
        private static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        public static string CreatePasswordSalt(string password)
        {
            //random salt for each user
            byte[] buf = new byte[SALT_SIZE];
            rng.GetBytes(buf);
            string salt = Convert.ToBase64String(buf);
            Rfc2898DeriveBytes deriver2898 = new Rfc2898DeriveBytes(password.Trim(), buf, NUM_ITERATIONS);
            string hash = Convert.ToBase64String(deriver2898.GetBytes(16));
            //salt will be saved in the database with hash_value
            return salt + ':' + hash;
        }

    }
}
