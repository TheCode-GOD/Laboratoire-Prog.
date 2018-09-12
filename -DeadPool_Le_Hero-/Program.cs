using System;

namespace _DeadPool_Le_Hero_
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbAlt = 0;
            int dp = 0;
            bool deuxChance = true;
            int mort = 0;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();





            Console.WriteLine("-Bienvenu ! Avant de commencer je vais vous expliquer les règles de base-");
            Console.WriteLine("                                                          ");
            Console.WriteLine("-Il vous faut bien suivre les consignes et respecter les chiffres indiqués s-il vous plait");
            Console.WriteLine("-Par la suite, un conseil, placer votre main gauche sur les touches 1 et 2");
            Console.WriteLine(" et votre main droite sur la touche <Entrer> pour confirmer vos choix, cela ira mieux ");
            Console.WriteLine("-Placez le jeu en mode plein-écran <du à la longueur des textes>");
            Console.WriteLine("-Notez bien que dans ce jeu le FBI vous aura bien à l'oeil");
            Console.WriteLine("                                                      ");
            Console.WriteLine("-Ensuite le but du jeu est simple-");
            Console.WriteLine("                                                       ");
            Console.WriteLine("Il faut faire des choix en appuyant sur les touches 1 et 2 pour avancer dans les scénarios");
            Console.WriteLine("Faites attention parfois vous pouvez revenir en arriere ou mourrir ");
            Console.WriteLine("De plus, il n'y a que une seule facon de gagner à ce jeu et c'est en sortant DeadPool de son ennuie");
            Console.WriteLine("                                         ");
            Console.WriteLine("J'en ai fini avec toutes ces consignes maintenant à vous de jouer !");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("Imaginez vous que vous êtes DeadPool. Callez vous bien dans votre fauteuil, vous etes maintenant un super héro, assis seul dans sont salon avec la vue sur NYC depuis le 10ieme étage  ");
            Console.WriteLine("                                                                                                                  ");
            Console.WriteLine("Alors que vous regardez dehors pour voir a quel point votre vie est triste et très peu active depuis la sortie de la beta de Battlefield 5 ");
            Console.WriteLine("De plus, depuis les 2 pour 1 au Boston Pizza. Il se trouve que vous avez pris un peu de poids ... genre 200 livres et  vous decidez que vous devez bouger un peu ");
            Console.WriteLine("Vous vous dites qu'il n'a rien de mieux pour vous que de re-telecharger un vieille application sur votre cell qui vous permettait de vous depensez ");
            Console.WriteLine("L'application en tant que tel, ne vous permettera pas de perdre du poids, mais juste de sortir votre tas de grasse de la maison et de vous'amusez ");
            Console.WriteLine("l'application est simple: Il s'agit d'une roulette qui vous donne une activité aléatoire et vous decidez de l'instaler  ");
            Console.WriteLine("Alors vous vous levez fesant tomber les tours de boites de pizza autour de vous et commencez le jeu ");
            Console.WriteLine("                                                        ");
            Console.WriteLine("Pour commencer appuyer sur le 1");



            dp = Convert.ToInt32(Console.ReadLine());

            if (dp == 1)
            {
                Console.WriteLine("Pour commencer, de quelle facon vous voulez sortir ? ");
                Console.WriteLine("                                             ");
                Console.WriteLine("La numéro 1 est de sortir par la porte ");
                Console.WriteLine("La numéro 2 est de sortir par la fenêtre ?");

                dp = Convert.ToInt32(Console.ReadLine());

                if (dp == 1)
                {
                    Console.WriteLine("Arrivé a la sortie de votre appartement, deux choix est possible alors où voulez-vous allez ");
                    Console.WriteLine("                                                   ");
                    Console.WriteLine("Le numéro 1 est d'aller gauche pour prendre l'escalier");
                    Console.WriteLine("Le numéro 2 est que vous prennez l'ascensseur où la porte est déjà ouverte avec un gros chef bandit à l'interieur");

                    dp = Convert.ToInt32(Console.ReadLine());

                    if (dp == 1)
                    {
                        Console.WriteLine("Vous descendez normalement les escaliers en glissant sur la rampe et en faisant des figures stylées et vous arrivez au pied de votre appartement  ");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Appuyez sur le 1 pour continuer");
                    }

                    else if (dp == 2)
                    {
                        Console.WriteLine("Vous rentrez dans l'ascensseur, vous êtes pris entre le gros chef bandit et sa bande. Vous êtes coincé un peu et ça pue mais vous dessendez normalement et vous arrivez au pied de votre appartement   ");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Appuyer sur le 1 pour continuer");
                    }
                }
                else if (dp == 2)
                {

                    Console.WriteLine("Arriver en borbure de la fenêtre de votre dixième étage,vous-avez deux choix pour tenter votre atterisage ");
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("Le numéro 1 est d atterrir sur un tobogan ");
                    Console.WriteLine("Le numéro 2 est d'ammortir votre chute à l'aide de la mercèdez stationnée en bas");

                    dp = Convert.ToInt32(Console.ReadLine());

                    if (dp == 1)
                    {
                        Console.WriteLine("Votre atterissage se fait de facon stylé, durant votre dessente, vous avez eu le temps de faire un PentaBackFlip 10 080 et atterrissez dans le tobogan qui a amorti votre chute. C'est alors que vous vous tenez au pied de votre appartement  ");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Appuyer sur le 1 pour continuer");
                    }

                    else if (dp == 2)
                    {
                        Console.WriteLine("Huhmm, j'espère que vous n'avez pas reflechi avant de prendre cette décision, parce qu'au moins ça vous donne une raison");
                        Console.WriteLine("Alors vous chutez de facon drastique et vous essayez de cadrer votre angle de chute pour atterrir sur la voiture qui vaut la plus chère");
                        Console.WriteLine("Maleureusement, le vent a fait changer votre trajectoire et vous arrivez sur une vieille camionette GMC 1981 avec une remorque remplis de fummier");
                        Console.WriteLine("Vous arrivez dans la remorque remplie a rebord de Merde, cela armorti votre chute mais pas de la facon que vous espèriez, mais vous arriver au pied de votre appartement");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Appuyez sur le 1 pour continuer ");
                    }
                }

            }


            dp = Convert.ToInt32(Console.ReadLine());

            while (deuxChance == true)
            {
                afficherScenarioAventure();

                Console.WriteLine("                                      ");
                Console.WriteLine("Pour activer la roulette appuyez sur 1");

                dp = Convert.ToInt32(Console.ReadLine());

                Random aleatoire = new Random();
                nbAlt = aleatoire.Next(1, 12);

                if (nbAlt <= 4)
                {
                    Console.WriteLine("Vous-avez reçu l'activité d'aller à la chasse!");
                    Console.WriteLine("                                                                                     ");
                    Console.WriteLine("Vous prennez l'avion et aller faire un safari dans une jungle en Amerique du sud ");
                    Console.WriteLine("vous arrivez dans la jungle et vous etes armé pour une fois d'un vrai fusil de chasse et non de vos deux pistolets préférés");
                    Console.WriteLine("Ca fait déjà un bon moment que vous marchez dans la jungle et enfin vous appercevez enfin votre première sillouette ");
                    Console.WriteLine("Vous avez de la difficulté à la distinguer à travers les branches alors, que decidez vous de faire comme choix ?");
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("Le numéro 1 est de tirer");
                    Console.WriteLine("Le numéro 2 est de tirer quand même ");
                    dp = Convert.ToInt32(Console.ReadLine());

                    if (dp == 1)
                    {
                        Console.WriteLine("Vous vous rapprochez de la cible et vous remarquez que vous avez tiré dans la jambre d'un éléphant ");
                        Console.WriteLine("Heureusement, vous avez tiré à coté de la passagère qui chevauchait la bête ");
                        Console.WriteLine("Alors que faites-vous ? plusieur choix s'offre à vous");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Le numéro 1 est de buter l'animal sauvagement et de le garder comme trophée ");
                        Console.WriteLine("Le numéro 2 est de decider de soigner l'animal avec votre trousse de premier soins ");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Après avoir decidé de faire passer votre arme de chasse en mode Automatique et d'avoir tirer le reste de votre chargeur sur l'animal");
                            Console.WriteLine("C'est alors que pendant que vous regardez le résultat de votre acte de barbarie ");
                            Console.WriteLine("Le FBI arrive en trombe en compagnie de 100 000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                            Console.WriteLine("Il vous surveillait de près et attendait que vous fesiez un erreur pour vous attrapper");
                            Console.WriteLine("En vous rappelant qu'il est interdit de tuer des animaux en voie de disparition");
                            Console.WriteLine("Vous ne coopérer pas car vous êtes DeadPool et l armée vous explose a l arme atomique!");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur  le 1");

                            mort = Convert.ToInt32(Console.Read());

                            if (mort == 1)
                            {
                                Environment.Exit(-1);
                            }
                        }


                        else if (dp == 2)
                        {
                            Console.WriteLine("Alors, que vous soignez l'animal la passagère vous reconnait et trouve que votre geste est très attentionné ");
                            Console.WriteLine("Elle désire prendre une photo avec vous mais vous êtes DeadPool et vous n'êtes pas vraiment ce type là ");
                            Console.WriteLine("Vous la butez de facon discrête et vous balancez son corps dans la rivière pour pas qu'il est de preuve");
                            Console.WriteLine("Vous trouvez cette activité complètement nulle et ce n'est pas votre genre d'aider les animaux. Alors, vous allez chercher une nouvelle activité");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Appuyez sur le 1 pour faire tourner la roulette de votre application pour une nouvelle activité");

                            dp = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    else if (dp == 2)
                    {

                        Console.WriteLine("HuHmmm, vous avez un peu hésité avant de tirer mais vous tirez quand même");
                        Console.WriteLine("Vous vous rapprochez de la cible et vous remarquez que vous avez tirer à coté d'un gros éléphant");
                        Console.WriteLine("Il ne fallait pas trop hésiter, mais bon...");
                        Console.WriteLine("Malheureusement l'animal s'est enfuit et vous avez tiré dans la jambre de la fille qui chevauchait l'animal");
                        Console.WriteLine("Maintenant qu'il y a une fille blessée devant vous. Vous avez un choix à faire");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Le numéro 1 est de la soigner à l'aide de votre trousse de premier soins");
                        Console.WriteLine("Le numéro 2 est simplement de la buter");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Vous sortez votre trousse de soins et commencez a aider la jeune fille en détresse");
                            Console.WriteLine("Blessée par votre arme, vous vous excusez tout en appliquant les premiers soins");
                            Console.WriteLine("Apres être soignée, la demoisselle désire prendre une photo avec vous ");
                            Console.WriteLine("Du au fait que vous êtes connu et que vous portez toujours votre costume ");
                            Console.WriteLine("En acceptant a contre-coeur vous prennez la photo");
                            Console.WriteLine("Mais la photographie n'étant vraiment pas votre truc");
                            Console.WriteLine("Cela vous décourage sur le coup,  et vous voulez faire une autre activité");
                            Console.WriteLine("Dégoutée par cette chasse, vous sortez votre téléphone et vous desirez lancer à nouveau la roulette pour une nouvelle activité");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Appuyez sur  le 1 pour faire tourner la roulette de votre application pour une nouvelle activité");

                            dp = Convert.ToInt32(Console.ReadLine());

                        }

                        else if (dp == 2)
                        {
                            Console.WriteLine("Vous décidez alors de sortir vos katanas et d'achever la jeune fille");
                            Console.WriteLine("Vous lui tranchez la tête d'une force qui n'était pas vraiment néscessaire");
                            Console.WriteLine("C'est alors que pendant que vous regardez cette scène");
                            Console.WriteLine("Le FBI arrive en trombe en compagnie de 100 000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                            Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous attrapper");
                            Console.WriteLine("En vous rappelant qu'il est interdit de tuer des jeunes filles sans défense");
                            Console.WriteLine("Vous ne coopérer pas car vous êtes DeadPool et l armé vous explose à l'arme chimique!");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur le 1");

                            mort = Convert.ToInt32(Console.Read());

                            if (mort == 1)
                            {
                                Environment.Exit(-1);
                            }

                        }
                    }
                }
                if (nbAlt <= 8)
                {

                    Console.WriteLine("Vous-avez reçu l'activité d'aller combattre le crime! ");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("Vous arrivez dans la rue en bas de votre appartement et vous vous dites que c'est vraiment la journee parfaite pour aller combattre le crime ");
                    Console.WriteLine("Justement, il n'y a pas très longtemps, à la télé vous avez entendu parler d'un criminel tr;és endurci du nom de Don Simonez McDoublez  ");
                    Console.WriteLine("Cette crapule contrôle plus de 75 pourcent du traffic de la drogue et 35 pourcent du traffic de McDouble au U.S.A.");
                    Console.WriteLine("Sinon vous savez aussi que le crime court dans les rues de NYC et encore plus dans la votre");
                    Console.WriteLine("Alors vous pouvez tenter votre destin seulement en allant marcher un peu dans votre rue ");
                    Console.WriteLine("Vous avez un choix à faire");
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("le numéro 1 est d'aller botter le cul du trafficant de renommée mondiale Don Simonez McDoublez");
                    Console.WriteLine("Le numéro 2 est d'aller voir qu'est-ce qu'il peut bien vous arriver dans votre rue à NYC ");

                    dp = Convert.ToInt32(Console.ReadLine());

                    if (dp == 1)
                    {
                        Console.WriteLine("Vous avez choisi d'aller combattre ce parrain de la drogue et des McDoubles");
                        Console.WriteLine("Mais on ne peut pas aller battre Don Simonez McDoublez comme ça ");
                        Console.WriteLine("Vous devez tout d'abord choisir votre arme avant !");
                        Console.WriteLine("Alors vous devez choisir en deux armes distingues");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("Le numéro 1 est évidement vos deux pistolets préférés que vous avez toujours au cours de vos aventures");
                        Console.WriteLine("Le numéro 2 est un lanche rocket 4 en 1 developé par la N.A.S.A. elle-même  ");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Vous avez choisi les deux pistolets préférés de DeadPool");
                            Console.WriteLine("Ils sont très efficaces avec leurs balles perforantes");
                            Console.WriteLine("Alors, après avoir choisi votre arme vous vous dirigez vers un ordinateur");
                            Console.WriteLine("Vous l'utilisez en tappant sur le clavier avec vos deux pistolets comme un vrai Americain ");
                            Console.WriteLine("Et vous allez sur FaceBook stalcker Don Simonez McDoublez et découvrez qu'il vit aussi a NYC");
                            Console.WriteLine("Vous appellez immédiatement Doppinder pour vous rendre sur les lieux");
                            Console.WriteLine("Alors vous arrivez devant le manoir du Parrain et c'est la nuit");
                            Console.WriteLine("Deux type de plan s'offre à vous");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Le numéro 1 est de faire une infiltration discrête tel un ninja");
                            Console.WriteLine("Le numéro 2 est de prendre un gros Hammer qui fait du bruit, garé juste a coté pour rentrer Yolo");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous avez choisi de faire une entrée furtive tel un vrai ninja");
                                Console.WriteLine("Vous contournez la demeure et grimpez sur les murs pour vous rendre sur les toits");
                                Console.WriteLine("vous esquivez le regard des garde situer plus bas tel un Samourai de l'infiltration");
                                Console.WriteLine("Vous trouvez enfin où se trouve Don Simonez McDoublez ");
                                Console.WriteLine("Et vous sautez du toit et arrivez derrière lui et il est pris au piège");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Pour continuer appuyez sur le 1");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous prennez vos deux pistolets et visez le parain qui tient qu'une simple peluche de McDouble");
                                    Console.WriteLine("Vous commencez a lui tirer dessus avec toute vos munitions mais rien ne se passe");
                                    Console.WriteLine("Le parain avait prévu que vous alliez prendre vos pistolets préférés sachant en plus que seulement vous, auriez pu le vaincre");
                                    Console.WriteLine("Il a fait faire un gilet pare-balle triple épaiseur de ciment et trempé dans l'adanmonium pour contrer vos pistolets ");
                                    Console.WriteLine("Alors il vous tire sa peluche de McDouble qu'il avait déjà rempli de C4 et vous fait exploser la tronche ");
                                    Console.WriteLine("                                                                                          ");
                                    Console.WriteLine("Vous êtes mort! Pour recommencer appuyez sur le 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }

                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous voyez le Hammer stationné dans une allée isolée et que 300 mètres sont requis pour arriver chez le parain");
                                Console.WriteLine("Il fait noir et aucun voisin ne peut vous voir le voler, car il y en a pas ... vous etes dans une allée isolée... ");
                                Console.WriteLine("Alors vous vous rapprochez du véhicule abandonné et vous réalisez que les clés sont encore a l'interieur ");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Pour démarer le Hammer appuyez sur le 1 ");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous essayez de démarer le véhicule mais rien ne se passe");
                                    Console.WriteLine("Vous tentez plusieurs coup et finalement un Click se fait entendre");
                                    Console.WriteLine("BOOM! Le Hammer explose ainsi que vous à l'intérieur");
                                    Console.WriteLine("Le FBI avait placé ce véhicule là, car il vous a vu stalcker le parain sur internet");
                                    Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous remettre à l'ordre");
                                    Console.WriteLine("En vous rappelant qu'il est interdit de voler des véhicules sans defense");
                                    Console.WriteLine("                                                        ");
                                    Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur le 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }
                            }

                        }

                        else if (dp == 2)
                        {
                            Console.WriteLine("Vous avez choisi le lance roquette 4 en 1 de la N.A.S.A.");
                            Console.WriteLine("Le 4 en 1 n'est pas pour quatre accessoires, mais pour 4 fois la puissance d'une roquette");
                            Console.WriteLine("C'est quand même la N.A.S.A.,il l'ont créé avec une puissance de feu pour détruire de petite comète");
                            Console.WriteLine("Alors, après avoir choisi votre arme, vous vous dirigez vers un ordinateur");
                            Console.WriteLine("Vous l'utilisez en tappant sur le clavier avec votre roquette comme un vrai Americain ");
                            Console.WriteLine("Et allez sur FaceBook stalcker Don Simonez McDoublez et decouvrez qu'il vit aussi a NYC");
                            Console.WriteLine("Vous appellez immédiatement Doppinder pour vous rendre sur les lieux");
                            Console.WriteLine("Alors vous arrivez devant le manoir du Parrain et c'est la nuit");
                            Console.WriteLine("Deux types de plan s'offre à vous");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("Le numéro 1 est de faire une infiltration discrète tel un ninja");
                            Console.WriteLine("Le numéro 2 est de prendre un gros Hammer qui fait du bruit, garé juste a coté pour rentrer Yolo");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous avez choisi de faire une entrée furtive tel un vrai ninja");
                                Console.WriteLine("Vous contournez la demeure et grimpez sur les murs pour vous rendre sur les toits");
                                Console.WriteLine("vous esquivez le regard des gardes situés plus bas, tel un Samourai de l'infiltration");
                                Console.WriteLine("Vous trouvez enfin où se trouve Don Simonez McDoublez ");
                                Console.WriteLine("Vous sautez du toit et arrivez derrière lui et il est pris au piège");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Pour continuer appuyez sur le 1");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous sortez votre roquette 4 en 1 qui était disimulée on sait où...");
                                    Console.WriteLine("Vous êtes en face de Don Simonez McDoublez et quand il voit la grosseur du roquette il se chie dessus ...");
                                    Console.WriteLine("Il en échappe sa peluche de McDouble par terre et vous lui tirez une très grosse roquette  ");
                                    Console.WriteLine("Même muni de son gilet pare-balle il explose en mille morceaux mais cela enlève au moins son odeur ");
                                    Console.WriteLine("Bien fier de vous , vous vous echappez de la demeure du parain ");
                                    Console.WriteLine("Mais trouvant ça trop facile vous décidez de retourner à votre appartement trouver une autre activité");
                                    Console.WriteLine("                                                        ");
                                    Console.WriteLine("Appuyez sur le 1 pour retourner à votre appartement faire la roulette d'activité");
                                }

                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous voyez le Hammer stationné dans une allée isolée et que 300 mètres sont requis pour arriver chez le parain");
                                Console.WriteLine("Il fait noir et aucun voisin ne peut vous voir le voler, car il y en a pas... Vous êtes dans une allée isolée ");
                                Console.WriteLine("Alors vous vous approchez du véhicule abandonné et realisez que les clés sont encore à l'intérieur ");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Pour démarer le Hammer appuyez sur le 1 ");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous essayez de démarer le véhicule mais rien ne se passe");
                                    Console.WriteLine("Vous tentez plusieurs coups et finalement un Click se fait entendre");
                                    Console.WriteLine("BOOM! Le Hammer explose ainsi que vous à l'interieur");
                                    Console.WriteLine("Le FBI avait placé ce véhicule là,  car il vous avait vu stalcker le parain sur internet");
                                    Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous remettre à l'ordre");
                                    Console.WriteLine("En vous rappelant qu'il est interdit de voler des véhicules sans défense");
                                    Console.WriteLine("                                                        ");
                                    Console.WriteLine("Désolé vous êtes mort!  Pour recommencer appuyez sur le 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }

                            }

                        }

                    }

                    else if (dp == 2)
                    {
                        Console.WriteLine("Vous avez choisi d'aller marcher dans votre rue à NYC pour voir ce que le destin vous réserve");
                        Console.WriteLine("Alors, vous marchez normalement et vous voyez qu'une vieille dame a l'air d'avoir de la difficulté à traverser la rue");
                        Console.WriteLine("Mais, quelques secondes plus tard, quelque chose vous dérange de votre intérêt pour cette vieille dame ");
                        Console.WriteLine("Un cri dans une ruelle attire votre attention, on dirait qu'une personne est en dificulté !");
                        Console.WriteLine("Alors un choix s'offre à vous !");
                        Console.WriteLine("                                                        ");
                        Console.WriteLine("le numéro 1 est de laisser faire ce cri et d'aller aider à traverser la rue à la vieille dame ");
                        Console.WriteLine("le numéro 2 est d'aller voir d'où provient ce cri ");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Vous avez décidé d'aider cette vieille dame à traverser la rue de facon sécuritaire ");
                            Console.WriteLine("Cette manoeuvre cause plusieurs accidents mais la vieille dame arrive de l'autre coté de la route ");
                            Console.WriteLine("Bien heureuse de voir qu'il y a encore de bonnes personnes en ce monde, elle vous demande de l'aider encore un peu");
                            Console.WriteLine("Avec vigueur, vous lui rappeler que vous êtes un tueur à gage et que vous n'êtes pas vraiment une bonne personne");
                            Console.WriteLine("Mais la vieille dame insiste sur le fait de lui donner un coup de main ");
                            Console.WriteLine("Alors que faites vous comme choix ?");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("le numéro 1 est d'accepter de l'aider ");
                            Console.WriteLine("le numéro 2 est de refuser d'aider cette vieille folle");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous decidez d'aider la vieille dame finalement");
                                Console.WriteLine("Elle vous demande de la suivre jusqu'à chez elle");
                                Console.WriteLine("Arrivé là-bas elle vous demande de l'aider a accomplir quelques tâches");
                                Console.WriteLine("Sans avoir le temps de placer un seul mot");
                                Console.WriteLine("Elle vous enfile un habit de femme de ménage et vous demande si vous pouvez faire le ménage");
                                Console.WriteLine("Croyant à la plus grande blague de l'univers vous dites");
                                Console.WriteLine("C'EST CLAIR QUE TU M'NIAISES !");
                                Console.WriteLine("J'SUIS LE TUEUR A GAGE LE PLUS INVINCIBLE DE LA TERRE! ");
                                Console.WriteLine("ET VOUS ME FAITES FAIRE VOTRE MENAGE ! JE SUIS DEADPOOL!!!");
                                Console.WriteLine("Vous êtes vraiment en colère et décidez de partir de là en mettant le feu à son habit de femme de ménage ");
                                Console.WriteLine("Malheureusement, l'habit a commencé à faire incendier sa maison ... ce n'était pas vraiemnt prévue..mais bon!");
                                Console.WriteLine("Vous vous en foutez ... mais vraiment beaucoup, du a cette énorme perte de temps");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Alors pour retourner faire une autre activé appuyez sur le 1");


                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("La vieille dame se met en colère et commence à dire l'inverse que précédement");
                                Console.WriteLine("Elle vous insulte de façon très intense sans arrêt et vous suit partout");
                                Console.WriteLine("Elle commence à vous sauter dessus en vous donnant des coups de canne sans arrêt");
                                Console.WriteLine("Vous vous défendez et une bataille commence avec la vieille dame");
                                Console.WriteLine("Vous essayez de la maîtriser mais elle est vraiment tenace");
                                Console.WriteLine("Vous décidez d'user d'un maximum de votre force contre cette chipie ");
                                Console.WriteLine("Mais étant une vieille dame cette force était un peu trop disproportionnée ");
                                Console.WriteLine("La vieille dame fait un vol plané et tombe dans la rue et malheureusement elle se fait frapper");
                                Console.WriteLine("Pendant que vous observez cette scène peu imaginable ");
                                Console.WriteLine("Le FBI arrive en trombe en compagnie de 100 000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                                Console.WriteLine("Il vous surveillait de près et attendait que vous fasssiez une erreur pour vous attrapper");
                                Console.WriteLine("En vous rappelant qu'il est interdit de tuer des vieilles dames sans défense");
                                Console.WriteLine("Vous ne coopérez pas car vous êtes DeadPool et le FBI vous explose à l'arme explosive!");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur le 1");

                                mort = Convert.ToInt32(Console.Read());

                                if (mort == 1)
                                {
                                    Environment.Exit(-1);
                                }

                            }
                        }

                        else if (dp == 2)
                        {
                            Console.WriteLine("Vous avez décidé d'aller voir d'où venait le cri");
                            Console.WriteLine("Vous suivez la provenance du cri et vous arrivez dans un ruelle");
                            Console.WriteLine("Vous voyez un groupe de personne s'en prendre à une dame pour lui prendre son sac à main");
                            Console.WriteLine("Elle arrive colée au fond de la ruelle et crie une dernière fois avant que le groupe arrive à la coincer  ");
                            Console.WriteLine("A vous d'intervenir. Que faites-vous pour l'aider? Deux choix s offrent à vous");
                            Console.WriteLine("                                                        ");
                            Console.WriteLine("le numéro 1 est de les neutraliser");
                            Console.WriteLine("le numéro 2 est de leur tirer dessus ");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous décidez de les neutraliser à l'aide de vos techniques d'arts martiaux");
                                Console.WriteLine("Il vous faut que quelques mouvements qui resemblent à un serpent qui mue, mais efficaces, pour les neutraliser");
                                Console.WriteLine("Vous prennez une corde qui traînait dans la ruelle et vous enroulez les méchants bandits avec celle-ci");
                                Console.WriteLine("Vous appellez Doppinder pour un transport jusqu'au commissariat pour y amener les bandits ");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Apuyez sur le 1 pour continuer");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous arrivez au poste de police à l'aide de votre chauffeur de taxi préféré");
                                    Console.WriteLine("Vous apportez les bandits à l'intérieur et vous attendez que l'on vous répondre");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("Après 8 longues heures d'attente vous en avez assez et vous décidez de laisser les bandits là ");
                                    Console.WriteLine("Vous insultez un peu le comissariat et ses agents et leurs lenteur épouvantable et partez");
                                    Console.WriteLine("Insulté de votre attente vous décidez de retourner à votre appartement pour une nouvelle activité");
                                    Console.WriteLine("                                                        ");
                                    Console.WriteLine("Appuyez surle 1 pour continuer");
                                }
                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous décidez de sortir vos deux pistolets et d'ouvrir le feu sur le groupe de bandits");
                                Console.WriteLine("Vous tirez jusqu'à ce que leurs membres se déchirent et qu'il y ait du sang partout");
                                Console.WriteLine("Vous dites alors à la dame qui est recouverte de sang, que c'est bien fait pour eux! Ils l'ont bien cherché");
                                Console.WriteLine("Alors, pendant que vous regardez cette scène qui est digne d'un rituel satanique de haut niveau");
                                Console.WriteLine("Le FBI arrive en trombe en compagnie de 100 000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                                Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous attrapper");
                                Console.WriteLine("En vous rappelant qu'il est interdit de tuer des bandits sans défense");
                                Console.WriteLine("Vous ne coopérer pas car vous êtes DeadPool et le FBI vous explose à l'arme bactériologique !");
                                Console.WriteLine("                                                        ");
                                Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur le 1");

                                mort = Convert.ToInt32(Console.Read());

                                if (mort == 1)
                                {
                                    Environment.Exit(-1);
                                }

                            }
                        }

                    }


                }

                else
                {
                    Console.WriteLine("Vous avez reçu l'activité d'aller commencer une troisième guerre mondiale!");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("Vous êtes vraiment content de faire une activité de ce genre ");
                    Console.WriteLine("Créer la discorde et de grandes batailles sanglantes est votre occupation préférée  ");
                    Console.WriteLine("Alors vous remontez dans votre appartement au dixième étage et vous décidez de vous assoir un peu...  ");
                    Console.WriteLine("...un choix s'impose à vous ... contre qui allez-vous entrer en guerre?");
                    Console.WriteLine("Faites le choix entre ces deux pays");
                    Console.WriteLine("                                                         ");
                    Console.WriteLine("Le numéro 1 est contre les Etats-Unis");
                    Console.WriteLine("Le numéro 2 est contre la Russie");

                    dp = Convert.ToInt32(Console.ReadLine());

                    if (dp == 1)
                    {
                        Console.WriteLine("Vous avez décidé d'aller en guerre contre les U.S.A.");
                        Console.WriteLine("C'est une bonne idée d'entrer en guerre contre soi-même");
                        Console.WriteLine("Alors vous prennez votre portable sur la droite et vous aller sur FaceBook faire un statut ");
                        Console.WriteLine("Vous exprimez à quel point le gouvernement de Trump détruit votre nation et que vous en avez marre");
                        Console.WriteLine("Vous l'insultez au plus haut point et dites au peuple de NYC de faire quelque chose !");
                        Console.WriteLine(" À la fin de votre message, vous avez le choix de le conclure de deux façons");
                        Console.WriteLine("                                                         ");
                        Console.WriteLine("Le numéro 1 est de déclarer l'anarchy et que le peuple se soulève !");
                        Console.WriteLine("Le numéro 2 est de dire aux gens que vous allez vous en charger tout seul et décidez d'aller magasiner avant");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Vous avez choisi  de déclarer l'anarchy dans tout NYC");
                            Console.WriteLine("Vous croyez que: Quelle partie du peuple se raliera à votre cause et se soulèvera ? ");
                            Console.WriteLine("                                                         ");
                            Console.WriteLine("Le numéro 1 sont les gens du centre ville");
                            Console.WriteLine("Le numéro 2 sont les gens des banlieux et des campagnes ");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous croyez que les gens du centre ville vont se souveler et c'est exactement se qui se passe");
                                Console.WriteLine("Votre message sur FaceBook frappe comme la foudre et 15 min après vous entendez déjà des coups de feu et des bruits explosions ");
                                Console.WriteLine("Vous ne pensiez pas que votre statut allait avoir un tel effect");
                                Console.WriteLine("Vous descendez de votre appartement en trombe et vous constatez à quel point NYC est déjà méconnaissable");
                                Console.WriteLine("les gens brûlent les voitures ... tirent sur la police .... l'anarchy totale est en cours au centre-ville");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Pour prendre part aux manifestations apuyez sur le 1");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Pendant que vous vous préparez à prendre vos pistolets vous observez ce désastre occulaire");
                                    Console.WriteLine("Vous n'avez même pas le temps d'ouvrir le feu que¸...");
                                    Console.WriteLine("Le FBI arrive en trombe en compagnie de 100 000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                                    Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous attrapper");
                                    Console.WriteLine("En vous rappelant qu'il est interdit de commencer une guerre contre un gouvernement sans défense");
                                    Console.WriteLine("Vous ne coopérez pas car vous êtes DeadPool et le FBI vous explose à l'arme nucleaire !");
                                    Console.WriteLine("                                                        ");
                                    Console.WriteLine("Désoér vous etes mort! Pour recommencer appuyez sur le 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }

                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous croyez que les gens de la banlieu et de la campagne vont se soulever et c'est exactement ce qui se passe");
                                Console.WriteLine("Votre message sur FaceBook frappe comme la foudre et 15 minutes après vous entendez aux nouvelles qu'une armée de villagois se sont rassemblés en bordure de la ville");
                                Console.WriteLine("Vous entendez dire qu'ils n'attendent qu'un nouveau statut de votre part pour commencer l'assault contre NYC");
                                Console.WriteLine("Alors pour écrire votre nouveau statut vous avez le choix entre deux types d'arme");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Le numéro 1 est d'attaquer la ville avec leur arme préférée qui est la faux");
                                Console.WriteLine("Le numéro 2 est de lancer l'assault a dos d'âne");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous avez écrit sur FaceBook qu'il fallait aller attaquer la ville à l'aide de faux ");
                                    Console.WriteLine("Alors vous allez voir votre petite armée en bordure de la ville ");
                                    Console.WriteLine("Doppinder vous dépose devant le groupe de manifestant et à votre grande déception");
                                    Console.WriteLine("il n'y a qu'un petit groupe d'environ 100 à 150 villageois ");
                                    Console.WriteLine("Et vous réalisez que votre assault sur NYC ne sera pas très efficace");
                                    Console.WriteLine("Alors vous criez aux villageois de rentrer chez eux et qu'avec cette petite troupe on allait même pas arriver à dévaliser un Dollorama");
                                    Console.WriteLine("Déçu de cette tentative d'attaque minable vous retournez à votre appartement pour vous trouvez une autre activité");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Pour retourner à votre appartement et tourner la roulette d'activité appuyez sur le 1");



                                }

                                else if (dp == 2)
                                {
                                    Console.WriteLine("Vous avez écrit sur FaceBook qu'il faullait aller attaquer la ville à dos d'âne");
                                    Console.WriteLine("Alors vous allez voir votre petite armée en borbure de la ville");
                                    Console.WriteLine("Doppinder vous dépose devant le groupe de manifestant et à votre grande déception ");
                                    Console.WriteLine("Il n'y a qu'un petit groupe d'environ 100 à 150 villageois");
                                    Console.WriteLine("Et vous réalisez que votre assault sur NYC ne sera pas très efficace");
                                    Console.WriteLine("Alors vous criez aux villageois de rentrer chez eux et qu'avec cette petite troupe on allait même pas arriver à dévaliser un Dollorama");
                                    Console.WriteLine("Déçu de cette tentative d'attaque minable vous retournez à votre appartement pour vous trouvez une autre activité");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Pour retourner à votre appartement et tourner la roulette d'activité appuyez sur le 1");

                                }
                            }

                        }

                        else if (dp == 2)
                        {
                            Console.WriteLine("Vous avez décidé d'aller magasiner pour bien préparer votre guerre");
                            Console.WriteLine("Vous allez sur EverythingForWar.com et vous commencez votre magasinage");
                            Console.WriteLine("Sur le site deux élements vous intéressent pour votre guerre");
                            Console.WriteLine("                                                         ");
                            Console.WriteLine("Le numéro 1 est une armée de mercenaires sans pitié les plus sanginaires et impitoyables");
                            Console.WriteLine("Le numéro 2 est une armée de carlins incontrolables et habillés en soldat et saliveux à souhait  ");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous avez choisi l'armée de mercenaires");
                                Console.WriteLine("ce sont de vrais brutes et ils sont d'une force incroyable ");
                                Console.WriteLine("Sur le site on vous demande combien de mercenaires vous voulez embaucher");
                                Console.WriteLine("Alors choissisez le nombre à embaucher");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Le numéro 1 est d'embaucher une centaine de mercenaires pour 1 000 000 $");
                                Console.WriteLine("Le numéro 2 est d'embaucher un millier de mercenaires pour 10 000 000 $");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous avez décidez d'embaucher une centaine");
                                    Console.WriteLine("Vous payez votre commande et on vous dit que les mercenaires arriveront pendant la journée");
                                    Console.WriteLine("Alors vous patientez en étant impatient de recevoir vos soldats");
                                    Console.WriteLine("Tout à coup on frappe à la porte ");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Pour allez ouvrir la porte appuyez sur le 1");

                                    dp = Convert.ToInt32(Console.ReadLine());

                                    if (dp == 1)
                                    {
                                        Console.WriteLine("Vous allez ouvrir la porte et surpris ce ne sont pas vos mercenaire mais bien...");
                                        Console.WriteLine("Le FBI qui arrive en trombe en compagnie de 1000 soldats armés jusqu'au dent pour vous mettre en état d'arrestation ");
                                        Console.WriteLine("Il vous surveillait de près et attendait que vous fassiez une erreur pour vous attrapper");
                                        Console.WriteLine("En vous rappelant qu'il est interdit d'acheter des mercenaires en ligne car ils n'ont pas de passeport pour entrer au U.S.A.");
                                        Console.WriteLine("Vous ne coopérer pas car vous êtes ¨DeadPool et le FBI vous explose à l'arme à impulsion magnétique!");
                                        Console.WriteLine("                                                        ");
                                        Console.WriteLine("Désolé vous êtes mort! Pour recommencer appuyez sur le 1");

                                        mort = Convert.ToInt32(Console.Read());

                                        if (mort == 1)
                                        {
                                            Environment.Exit(-1);
                                        }
                                    }

                                }

                                else if (dp == 2)
                                {
                                    Console.WriteLine("Vous avez décidez d'embaucher un millier de mercenaires");
                                    Console.WriteLine("Vous payez et rien ne se passe....");
                                    Console.WriteLine("vous réessayez mais toujours rien ne se passe...");
                                    Console.WriteLine("Finalement vous tentez une dernière fois et un message apparait sur le site");
                                    Console.WriteLine("                     ");
                                    Console.WriteLine("Il est écrit : Fonds insuffisant!!! Arrêter d'essayer vous n'avez pas cette somme, ça vient tannant à la longue ");
                                    Console.WriteLine("                      ");
                                    Console.WriteLine("Décu du site vous vous dites que cette façon de commencer cet guerre est trop chère ");
                                    Console.WriteLine("Alors vous allez tout simplement faire une autre activité qui est moins dispendieuse");
                                    Console.WriteLine("Vous vous levez et vous descendez en bas de votre appartement pour relancer la roulette d'activité");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Appuyez sur le 1 pour retourner à la roulette des activités ");
                                }
                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous avez choisi l'armée de Carlins ");
                                Console.WriteLine("Heureusement, le site vous informe que le produit est local ");
                                Console.WriteLine("Du coup, la livraison se fait à l'intérieur de la prochaine heure ");
                                Console.WriteLine("Alors vous n'hésitez pas et vous achetez cette armée de Carlins au modeste prix de 1 000 000 $");
                                Console.WriteLine("La transaction est acceptée et vous attendez vos Carlins soldats ");
                                Console.WriteLine("                                            ");
                                Console.WriteLine("1 heure s'est écoulée et déjà on sonne à la porte et derrière vous entendez vos Carlins enragés ");
                                Console.WriteLine("Vous ouvrez la porte et les milliers de Carlin pénètrent dans votre appartement ");
                                Console.WriteLine("Vous n'avez aucun contrôle sur les Çarlins et le bordel s'installe rapidement chez vous");
                                Console.WriteLine("Vous avez deux choix pour contrôler vos bêtes");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Le numéro 1 est le sifflet pour chien inclus dans votre achat");
                                Console.WriteLine("Le numéro 2 est du bacon ");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous avez décider d'utiliser le sifflet pour chien afin de maîtriser ces incontrôlables bêtes sauvages");
                                    Console.WriteLine("Malheureusement les Carlins étant des Carlins ils n'ecoutent rien ");
                                    Console.WriteLine("ils détruisent tout votre appartement ne laissant que salives et moulures mangées derrière eux");
                                    Console.WriteLine("Réalisant que vous vous êtes fait arnaquer solide, vous retournez votre armée de Carlins soldats au détaillant");
                                    Console.WriteLine("Finalement, après quelques heures le livreur rammasent tous vos chiens ");
                                    Console.WriteLine("Déçu de votre tentative infructueuse de commencer une guerre vous descendez en bas de votre appartement pour refaire tourner la roulette d'activité");
                                    Console.WriteLine("            ");
                                    Console.WriteLine("Appuyez sur le 1 pour retourner à la roulette d'activité");
                                }

                                else if (dp == 2)
                                {
                                    Console.WriteLine("Vous avez décider d'utiliser le bacon pour maitriser les Carlins");
                                    Console.WriteLine("¸Malheureusement, même avec l'aide de cette nourriture ultra efficace ces chiens reste des Carlins et ils n'écoutent rien ");
                                    Console.WriteLine("Ils détruisent tout votre appartement ne laissant que salives et moulures mangées derrière eux");
                                    Console.WriteLine("Réalisant que vous vous êtes fait arnaquer solide¸,  vous retournez votre armée de Carlins au détaillant");
                                    Console.WriteLine("Finalement, après quelques heures le livreur rammase tous vos chiens ");
                                    Console.WriteLine("Déçu de votre tentative infructueuse de commencer une guerre vous descendez en bas de votre appartement pour refaire tourner la roulette d'activité");
                                    Console.WriteLine("            ");
                                    Console.WriteLine("Appuyez sur le 1 pour retourner à la roulette d'activité");
                                }

                            }

                        }

                    }

                    else if (dp == 2)
                    {
                        Console.WriteLine("Vous avez décidé d'aller en guerre contre la Russie");
                        Console.WriteLine("C'est toujours mieux de faire la guerre a un pays qui n'est pas le notre  ");
                        Console.WriteLine("Pour une raison qui n'est pas importante vous décidez que la Russie mérite de subir votre colère");
                        Console.WriteLine("Alors vous remontez à votre appartement et vous prennez votre portable");
                        Console.WriteLine("Vous allez sur FaceBook et vous commencez écrire un statut qui dénigre le président Vladimir Poutine");
                        Console.WriteLine("Vous utilisez votre registre des pires insultes pour qualifier son régime communiste de régime à 2 piastre et cela sans vous préoccupez de la réputation incontestable du 2 piastre. Vous lui dites de bien se préparer à attaque ");
                        Console.WriteLine("Alors s'offre à votre disposition deux moyens de vous rendre en Russie");
                        Console.WriteLine("                                                         ");
                        Console.WriteLine("Le numéro 1 est de détourner un avion et d'aller en Russie par la voie aérienne");
                        Console.WriteLine("Le numéro 2 est de détouner un bateau et d'aller en Russie par la voie maritine");

                        dp = Convert.ToInt32(Console.ReadLine());

                        if (dp == 1)
                        {
                            Console.WriteLine("Vous avez décidez de vous rendre en Russie par la voie aérienne");
                            Console.WriteLine("Alors vous allez à l'aéroport de NYC et vous y détourner un avion assez facilement");
                            Console.WriteLine("Vous arrivez en Russie sans trop de problèmes la météo étant de votre coté");
                            Console.WriteLine("Vous arrivez à votre destination dans un aéroport près de la capitale ");
                            Console.WriteLine("Vous débarquez de l'avion et vous marchez un peu dans l'aéroport. Vous avez maintenant un choix à faire car deux directions sont possibles");
                            Console.WriteLine("                                                         ");
                            Console.WriteLine("Le numéro 1 est de vous dirigez vers la Capitale de Moscou");
                            Console.WriteLine("Le numéro 2 est de tenter votre chance et de vous dirigez vers une belle Russe assise seule au bar");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous avez décider d'aller vers la capitale de Moscou");
                                Console.WriteLine("Vous appelez un taxi qui vient vous cherchez pour vous y ammener");
                                Console.WriteLine("Un chauffeur de taxi du nom de Ivan Doppinderkiezvsky vient vous prendre à l'aéroport");
                                Console.WriteLine("Vous faites toute la route en taxi et en chemin le conducteur vous racontre qu'un certain DeadPool Americain a créé un tas d'émeutes dans la capitale");
                                Console.WriteLine("Actuellement dans la capitale, deux fractions se font tête et il ne faudrait que quelques étincelles pour attiser le feu");
                                Console.WriteLine("Il vous dépose à Moscou et effectivement¸deux fractions se font tête à l aide d'AK-47 ");
                                Console.WriteLine("Alors deux possibilités s'offrent à vous pour commencer cette guerre ");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Le numéro 1 est de prendre le haut-parleur dans votre valise et de transformer la se tête à tête en rébellion");
                                Console.WriteLine("Le numéro 2 est de prendre la mini bombe nucléaire dans votre valise que vous avez réussi à faire passer en soudoyant les douaniers pour détruire la Russie");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Vous avez choisi de prendre le haut-parleur ");
                                    Console.WriteLine("Vous empoignez le gros micro de main ferme et vous incitez les manifestants à vous écouter");
                                    Console.WriteLine("Vous faites un discours en Russe parfait et vous endoctrinez facilement les fractions avec vos paroles dignes de Matin Luther King lui-même");
                                    Console.WriteLine("Les manifestants en colère prennent par à la rébellion immédiatement");
                                    Console.WriteLine("Il vous suffit seulement de 2 petites secondes après votre discours pour que les rebelles ouvrent le feu sur les autorités russes");
                                    Console.WriteLine("La guerre éclate rapidement en Russie et l'armée est obligée de venir en renfort mais les rebelles ont aussi des tanks en seconde ligne ... on est en Russie quand même¸!");
                                    Console.WriteLine("Vous aussi prennez part aux hostilités en tirant sur l'armeée Russe avec toute votre rage ");
                                    Console.WriteLine("Grace a votre rage l'armée russe subisant de lourdes pertes décide alors de battre en retraite ");
                                    Console.WriteLine("Alors par quel coté voulez-vous continuer votre assault");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Le numéro 1 est de continuer l'assault de front ");
                                    Console.WriteLine("Le numéro 2 est de continuer l'assault en contournant les troupes ennemies par la gauche et tenter un < Flank >  pour arriver derrière les troupes Russes");

                                    dp = Convert.ToInt32(Console.ReadLine());

                                    if (dp == 1)
                                    {
                                        Console.WriteLine("Vous avez choisi de faire front à l'armée Russe");
                                        Console.WriteLine("Vous tirez sur les Russes comme si vous étiez à la chasse aux canards");
                                        Console.WriteLine("Les Russes tombent comme des mouches et vous adorez cette activité");
                                        Console.WriteLine("Vous ne  vous étiez pas amusé autant que depuis la fameuse fête chez Tony Stark où vous aviez trouvé son armure ");
                                        Console.WriteLine("Vous lui aviez volé et vous aviez fait un concour de force contre Hulk dans toute la maison de Tony causant d'énorme dégats, mais ça c'est une autre histoire.  ");
                                        Console.WriteLine("Alors, les Russes subissent une lourde défaite et leur armée commence a partir en déroute  ");
                                        Console.WriteLine("Vous devez choisir entre deux plans");
                                        Console.WriteLine("                                                         ");
                                        Console.WriteLine("Le numéro 1 est de courrir après les Russes dans les rues et de détruire entièrement leurs troupes. Par la suite, il ne vous restera qu'à vous en prendre au président ");
                                        Console.WriteLine("Le numéro 2 est de courrir directement jusqu'au Capitole et d'y commencer l'assault");

                                        dp = Convert.ToInt32(Console.ReadLine());

                                        if (dp == 1)
                                        {
                                            Console.WriteLine("Vous avez décidé de courrir après les Russes dans les rues");
                                            Console.WriteLine("Pendant que vous courrez après les Russes pour les achever un par un, un soldat de leur armée se rend incognito au QG du KGB");
                                            Console.WriteLine("Depuis les années de la guerre froide, ils avaient garder un vieille commande qui permettait d'auto-détruire le pays en cas d'une défaite contre les Nazis");
                                            Console.WriteLine("Le soldat actionne la commande et active du coup une bombe nucléaire située en dessous de Moscou en criant: CYCLA BLAT !");
                                            Console.WriteLine("Pendant que vous tuez les Russes, jailli à l horizon une grande lumière blanche");
                                            Console.WriteLine("Une énorme explosion s'ensuit et anéanti la ville de Moscou et vous avec... ...malheureusement vous êtes mort dans les rues de la capitale");
                                            Console.WriteLine("                                                         ");
                                            Console.WriteLine("Désolé vous êtes mort¸! Pour recommencer appuyez sur le 1");

                                            mort = Convert.ToInt32(Console.Read());

                                            if (mort == 1)
                                            {
                                                Environment.Exit(-1);
                                            }
                                        }

                                        else if (dp == 2)
                                        {
                                            Console.WriteLine("Vous avez décidé de courrir jusqu'au Capitole et d'y commencer l'assault");
                                            Console.WriteLine("Votre assault est comme l'éclair et vous pénétrez dans la grande salle furtivement");
                                            Console.WriteLine("Le président ne s'attendait pas à vous voir arriver jusqu'ici mais les gardes chevronnés de Poutine oui et ils ouvrent le feu sur vous ");
                                            Console.WriteLine("Une énorme fusillade éclate entre vous et ses gardes d'élite mais vous prennez finalement le dessus et vous isolez le président dans  une salle");
                                            Console.WriteLine("Dans la salle, il ne reste plus que votre bande et le président Poutine désarmé alors vous rangez vos pistolets et sortez vos katanas");
                                            Console.WriteLine("                                                         ");
                                            Console.WriteLine("Pour exécuter le Président Vladimir Poutine appuyez sur le 1 ");

                                            dp = Convert.ToInt32(Console.ReadLine());

                                            if (dp == 1)
                                            {
                                                Console.WriteLine("<Slick>");
                                                Console.WriteLine("Vos coups de katana font roulez la tête du président par terre et pendant ce temps vos rebelles issent le drapeau de DeadPool sur le Capitole ");
                                                Console.WriteLine("Toutes les nations constatent très rapidement que la Russie est tombée sous la main d'un Americain sans l'accord de l'ONU");
                                                Console.WriteLine("Alors les nations qui etaient avec la Russie n'hésitent pas à ouvrir le feu sur les Americains et leurs alliés");
                                                Console.WriteLine("Et les nations aliees au Americain avec eu meme inclu ouvre a leur tout les hostilier contre les alliees des Russes ");
                                                Console.WriteLine("Une véritable guerre mondiale éclate sur terre et vous en êtes le seul responsable !");
                                                Console.WriteLine("Vous êtes satisfait du résultat et vous avez finalement fait une activité qui vous a fait plaisir ");
                                                Console.WriteLine("3 années passent et la guerre fait encore rage  ");
                                                Console.WriteLine("Pendant la guerre vous vous êtes isolé sur un île déserte dans les caraibes pour profiter du soleil et boire de l'alcool  ");
                                                Console.WriteLine("Vous allez rester là jusqu'a ce que les guerres se calment avant de rentrer a NYC");
                                                Console.WriteLine("                  ");
                                                Console.WriteLine("Pour continuer appuyez sur le 1 ");

                                                dp = Convert.ToInt32(Console.ReadLine());

                                                if (dp == 1)
                                                {
                                                    Console.WriteLine("-FELICITATION VOUS AVEZ GAGNÉ !-");
                                                    Console.WriteLine("                    ");
                                                    Console.WriteLine("                          ");
                                                    Console.WriteLine("Vous avez réussi a vaincre le jeu DeadPool_Le_Hero");
                                                    Console.WriteLine("Pour vous remerciez d'avoir participé voici une bonne main d'applaudissements ");
                                                    Console.WriteLine("                                   ");
                                                    Console.WriteLine("CLAP, CLAP, CLAP, CLAP, CLAP, CLAP, CLAP, CLAP, CLAP, CLAP, CLAP ");
                                                    Console.WriteLine("                                       ");
                                                    Console.WriteLine("Meri et au revoir! ");
                                                    Console.WriteLine("         ");
                                                    Console.WriteLine("Pour Fermer le jeu appuyez sur le 1");

                                                    mort = Convert.ToInt32(Console.Read());

                                                    if (mort == 1)
                                                    {
                                                        Environment.Exit(-1);
                                                    }
                                                }
                                            }
                                        }

                                    }

                                    else if (dp == 2)
                                    {
                                        Console.WriteLine("Vous avez choisi de contourner ");
                                        Console.WriteLine("Alors vous quittez vous ligne de front et decaler dans un rue a votre gauche qui a l air isoler des combats");
                                        Console.WriteLine("Arriver dans la rue vous arriver a une intersection et prennez a droit pour aller deriere l'armer Russe ");
                                        Console.WriteLine("Mais vous tourner le coin et tomber nez a nez a un tank Russe...");
                                        Console.WriteLine("Vous tirez dessus avec vos deux pistolets jusqu'a temps que vos chargeur se vide");
                                        Console.WriteLine("A cours de munition vous realiser a quel point vous etes dans la merde et sans avoir le temps de bouger le tank ouvre le feu!");
                                        Console.WriteLine("BOOM ! Il vous explose si violament qu on retrouvera vos morceau au quatre coin de la Russie");
                                        Console.WriteLine("                                                         ");
                                        Console.WriteLine("Desoler vous etes mort pour recommencer appuyez sur 1");

                                        mort = Convert.ToInt32(Console.Read());

                                        if (mort == 1)
                                        {
                                            Environment.Exit(-1);
                                        }

                                    }

                                }

                                else if (dp == 2)
                                {
                                    Console.WriteLine("vous avez choisi de prendre la bombe nucleaire ");
                                    Console.WriteLine("j'espere que que prendre ce choix etait un accidant car au moins ca vous donne une excuse");
                                    Console.WriteLine("Alors vous enclencher le mecanisme de la bombe et elle s'active aussitot");
                                    Console.WriteLine("Elle fait exploser la russie comme votre plan etait prevue mais vous avez oublier que vous etiez dans le rayon d'impact");
                                    Console.WriteLine("Boom ! vous exploser avec la Russie et vous etes mort ");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Pour recommencer appuyez sur 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }

                                }
                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous avez decidez d'aller voir cette tres charmante femme assise seul au bar demandant que votre reconfort");
                                Console.WriteLine("Vous tentez de la charmer a l aide de vos talents de super-hero qui on l'aie de fonctionner");
                                Console.WriteLine("Vous tomber fou amoureux de son accent et continuer de boire avec elle et cette apres-midi s'anime");
                                Console.WriteLine("elle vous offre meme a boire et vous accepter avec joie du a sont remarcable charme");
                                Console.WriteLine("Le serveur arrive avec vos deux shooters ");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Pour prendre le verre appuyez sur 1");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("Quelques secondes apres avoir pris le verre vous commencez a voir embrouiller ");
                                    Console.WriteLine("Et tout ta coup vous commencer a sentir le froid parcourir vos membres ");
                                    Console.WriteLine("Finalement votre coeur arrete de battre et vous mourrez tristement dans le pays du froid");
                                    Console.WriteLine("Le KGB avais mis cette espionne est place car depuis votre statu contre le president il vous suivait");
                                    Console.WriteLine("Il savait que vous alliez faire se type d'erreur qui vous a couter la vie");
                                    Console.WriteLine("Vous rappelant qu'on ne peut pas s'en prendre a vladimir Putin aussi facilement");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Desoler vous etes mort pour recommencer appuyez sur 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }
                            }

                        }

                        else if (dp == 2)
                        {
                            Console.WriteLine("Vous avez decidez de vous rendre en Russie pas la voie maritine");
                            Console.WriteLine("Vous detourner un bateau au port de NYC et surprenament vous avez une faciler deconcertante a le voler ");
                            Console.WriteLine("Vous sortez de la marina de NYC et savez pas trop vers quelles directions aller ");
                            Console.WriteLine("Vous sortez une carte une carte du monde qui se trouvait dans la cabine et deux choix s'offre a vous");
                            Console.WriteLine("                                                         ");
                            Console.WriteLine("Le numero 1 est d'aller en Russie par le Nord ");
                            Console.WriteLine("Le numero 2 est d'aller en Russie par le Sud");

                            dp = Convert.ToInt32(Console.ReadLine());

                            if (dp == 1)
                            {
                                Console.WriteLine("Vous avez decider d'aller en Russie par le Nord");
                                Console.WriteLine("Vous partez en haute mer et naviger vers le haut ");
                                Console.WriteLine("Votre periple devient plus intense quand le froid commence a s'instaler");
                                Console.WriteLine("maleureusement en faisant se choix vous n aviez pas prevue ca");
                                Console.WriteLine("Tout d'un coup de large banquise s'instale a l'horizon ");
                                Console.WriteLine("ne brusquant pas chemin vous continuer a avancer");
                                Console.WriteLine("Mais vous vous reveillez un jour pris completement prix au piege incapable d'avancer n'y de reculer");
                                Console.WriteLine("Vous etes a cour de provision et presque plus de carburant a un froid exterieur de -50 ");
                                Console.WriteLine("Vous prennez votre telephone en dernier recours pour que Doppinder vous vienne en aide mais plus de pile..");
                                Console.WriteLine("Vous accepter de que deadpool va mourrir de froid perdu dans l'artique et surment devorer par un ours polaire dans son coma");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("appuyez sur 1 pour accepter de mourrir de froid");
                            }

                            else if (dp == 2)
                            {
                                Console.WriteLine("Vous avez decider d'aller en Russie pas le Sud");
                                Console.WriteLine("Vous partez en haute mer et naviger vers le bas");
                                Console.WriteLine("Votre periple se deroule bien jusqu'a se que la chaleur s'intentifie");
                                Console.WriteLine("Alors vous naviger et vous voyez des mirages de licorne sur l'eau partout autour de vous  ");
                                Console.WriteLine("A la place de les exquivers vous decider d'en ecrasers une au hasard sous votre coque de bateau");
                                Console.WriteLine("                                                         ");
                                Console.WriteLine("Pour voir se qui ses passer quand vous avez passer sur une licorne appuyez sur 1");

                                dp = Convert.ToInt32(Console.ReadLine());

                                if (dp == 1)
                                {
                                    Console.WriteLine("BOOM ! Votre bateau explose dans un enorme deflagration");
                                    Console.WriteLine("Le FBI avais placer un champs de mines flotantes pour contrer les cargaisons de coke en provenance de la Colombie");
                                    Console.WriteLine("Il avais remplis ses mines avec asser de C4 pour detruire un bateau 4x plus grand que le Titanic ");
                                    Console.WriteLine("Il attendait que les marins clandestins franchise ses champs pour les punir ");
                                    Console.WriteLine("En rapplant qu'il est impossible de franchir la fontiere maritime des U.S.A.");
                                    Console.WriteLine("                                                         ");
                                    Console.WriteLine("Vous etes mort pour recommencer appuyez sur 1");

                                    mort = Convert.ToInt32(Console.Read());

                                    if (mort == 1)
                                    {
                                        Environment.Exit(-1);
                                    }
                                }

                            }

                        }
                    }

                }


            }
            Console.ReadKey();
        }
        static public void afficherScenarioAventure()
        {
            Console.WriteLine("Arrivé au rez-de-chaussée de votre résidence, vous décidez enfin de sortir votre téléphone et d'ouvrir votre application.");
            Console.WriteLine("Le foncionnement est simple vous appuyez sur le 1 et la roulette vous donne une des trois activités de façon aléatoire ");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("Les trois activités sont les suivantes");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("-La première est d'aller à la chasse");
            Console.WriteLine("-La deuxième est d'aller combattre le crime");
            Console.WriteLine("-La troisième et dernière activité est de commencer une troisième guerre mondiale");

        }
    }
}
