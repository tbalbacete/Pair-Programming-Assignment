using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace myGame
{
    public class Orb
    {
        public string orbName;
        public string powerType;
        public int strengthLevel;

        public void orbType()
        {  
            Console.Write($"You found {orbName} its power is {powerType}!! It has a half life strength of {strengthLevel}.");
        }

    }

    public class Players
    {
        public string playerName;
        public string playerStrength;
        public int playerOrbAmount;

        public void playerType()
        {  
            Console.Write($"DNA LINKED NAME: {playerName}. X-ORBS: {playerOrbAmount} . HALF LIFE STRENGTH: {playerStrength}.");
        }

    }

    public class Town
    {
        public string townName;
        public int orbCount;

        public void townType()
        {  
            Console.Write($"THIS IS: {townName}. THERE ARE {orbCount} X ORBS REMAINING HERE ");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            legendOfTheOrbs();
        }

        public static void legendOfTheOrbs ()
        {
            
            Console.WriteLine("Welcome to THE LEGEND OF THE ORBS! Press ENTER to begin");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have just made the long journey up Mt. Restic to the secluded home of Dr. Q. \nHe is anxiously awaiting your visit... \n\nPRESS ENTER TO KNOCK AT THE DOOR");
            Console.ReadLine();
            Console.Clear();
            Console.Write("DR Q: Oh Hello!! I'm glad you made it here! Please, come in...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Well then, before we get started here, what is your name? ");
            string mainChar = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Lovely to meet you, " + mainChar +  ", I'm Dr. Q, but *laughs* ... you already knew that!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(mainChar + ", your bravery will be rewarded in more ways than you can ever imagine... are you ready to begin? Y/N");
            string decision = Console.ReadLine();
            Console.Clear();

            if (decision == "y") {
                Console.WriteLine("Wonderful, let's begin!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (decision == "n"){
                Console.WriteLine("I'm sorry you've come all this way for nothing. I wish you all the best.");
                Console.ReadLine();
                Console.Clear();
                endGame();
            }
            else {
                Console.WriteLine("So eager to start, that you hit the wrong key! I love the enthusiasm!");
                Console.ReadLine();
                Console.Clear();
            }
            

            Console.WriteLine("100 million years ago, the only thing in existence was THE MONOSPHERE... ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE MONOSPHERE was a highly condensed collection of the monatomic antimatter element known as XEE. \nOver time, the exponential double timing of this element became far too great, and THE MONOSPHERE burst. \nIt created every universe, every star, every planet, every organism, every atom.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is the origin of all life. Everything begins and ends in THE MONOSPHERE. We are all made up of XEE. ");
                Console.ReadLine();
                Console.Clear();
            Console.WriteLine("Have I lost you yet?? Y/N");
            string responseOne = Console.ReadLine();
            Console.Clear();

            if (responseOne == "n"){
                Console.WriteLine("Excellent... Because here's the thing, " + mainChar + "... XEE still exists today. It has never been found, nor recreated, but it is out there...");
                Console.ReadLine();
                Console.Clear();

            }
            else if (responseOne == "y"){
                Console.WriteLine("I'm sorry you've come all this way for nothing. I wish you all the best.");
                Console.ReadLine();
                Console.Clear();
                endGame();
            }
            else {
                Console.WriteLine("So eager to start, that you hit the wrong key! I love the enthusiasm!");
            }
            

            Console.WriteLine("It's never been found because no one has this - THE OCCULEX.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE OCCULEX look like a simple set of glasses, but I have devoted my life to creating them specifically to detect XEE. \n\nWhen you are nearing XEE, the lenses will start to shade. The closer you get, the darker the shade. \n\nWhen the glasses are nearly blacked out - that's when you dig! The orbs are invisible to the naked eye. You will only be able to see them through the darkened glasses... \n\nPut them on...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AS YOU PUT ON THE OCCULEX, THEY IMMEDIATELY DARKEN!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR Q: Hold out your hand...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This is an X-ORB. When THE MONOSPHERE burst, XEE was no longer monatomic. \nEach orb contains different elements, which when combined with XEE, do different things. \nThis particular orb grants the power of invisibility!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now, the last thing...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Take this pill. It is pure XEE. When you take this, your DNA will be linked to every X-ORB you find, so you can reap all the benefits. \nOnce linked to your DNA, no one else can be linked to that X-ORB.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Let me walk you to the door...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thank you for coming and listening to me... I wish you all the best, and please come back soon to tell me about your adventures!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR Q HOLDS UP HIS X-ORB AND SQUEEZES IT... SUDDENLY, HE VANISHES INTO THIN AIR!!!");
            Console.ReadLine();
            Console.Clear();
                 


// LEVEL ONE //



            bool userChoice=false;
            
            do 
            {
                Console.WriteLine("AS YOU WALK DOWN THE PATH AWAY FROM DR Q'S HOUSE, YOU COME UPON A FORK IN THE ROAD. \nDO YOU WANT TO GO LEFT OR RIGHT?");
                string directionChoiceOne = Console.ReadLine();
                Console.Clear();
                if(directionChoiceOne == "r" || directionChoiceOne == "right" || directionChoiceOne == "l" || directionChoiceOne == "left")
                {
                    userChoice = true;
                
                    switch (directionChoiceOne)
                    {
                    case "right" or "r" :
                    Console.Clear();
                    break;

                    case "left" or "l" :
                    Console.WriteLine("What the?? THE OCCULEX are getting dark!!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("YOU SLOW DOWN YOUR WALK AND THE OCCULEX ARE ALMOST COMPLETELY BLACK. YOU KNEEL AND START TO DIG WITH YOUR HANDS...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("YOU DIG PAST A ROOT... A FEW ROCKS... INCHING DEEPER INTO THE EARTH...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Oh my god... is that... is that an X-ORB?!?!");
                    Console.ReadLine();
                    Console.Clear();

                    Orb flight = new Orb();
                    flight.orbName = "X-ORB-934...";
                    flight.powerType = "FLIGHT!!";
                    flight.strengthLevel = 50;
                    flight.orbType();


                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Wow, I can't believe this!! I thought I might find one... but not this fast!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("YOU PUT THE X-ORB INTO YOUR BACK PACK, FILL THE DIRT BACK INTO THE HOLE YOU DUG, AND DOUBLED BACK TO THE OTHER PATH");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select Left or Right.");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("Invalid Answer, please select L or R");
                }
            }
            
            while (userChoice == false);

// LEVEL TWO // 
        
            Console.WriteLine("I remember this path... It should take me back to my tent.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AS YOU WALK DOWN THE PATH YOU START TO HEAR SOMETHING IN THE DISTANCE");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Am I losing it?? I feel like I hear my name...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE NOISE GROWS LOUDER AND LOUDER...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ok, what the heck... I DO hear my name!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Whoa!! Doc??? Are you alright???");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q APPEARS ON THE PATH, DISHEVELED AND BREATHLESS AFTER SCREAMING FOR YOU FOR MILES");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: " + mainChar + "!! I'm SO glad I caught you!! \n\nRight after you left, someone broke into my lab and stole almost everything! The XEE pills, my OCCULEX prototype, even my Monosphere coffee mug!! I think someone was listening in on us and they know how to get X-ORBS too!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have to be careful! If X-ORBS fell into the wrong hands, I... I don't even want to think about it. \nIt could be the end of civilization as we know it!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oh no, Doc!! I am so sorry -- I will be careful and be on the lookout for anyone else who looks like they might be searching for X-ORBS. \nHere, why don't we exchange numbers so we can communicate easier without you running all over kingdom come again.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR Q: Good idea... thank you. I need to head back now, before anything else happens!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR Q DISAPPEARS INTO THE WOODS...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I can't believe it... I better set up a makeshift camp for the night; I don't think I'll make it back to my tent before dusk...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU BUILD A SHELTER OF BRANCHES AND LEAVES JUST AS NIGHT FALLS UPON MT. RESTIC...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...zzz...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".....zzz.....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...zzz...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".....zzz.....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...zzz...");
            Console.ReadLine();
            Console.Clear();


// LEVEL THREE //


            Console.WriteLine("THE NEXT DAY");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A beautiful morning on Mt. Restic... Time to get to it! I just know I'm going to find more X-ORBS today!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU PUT ON YOUR BACK PACK AND THE OCCULEX, AND CLEAR THE BRANCHES OVERHANGING THE ENTRANCE TO YOUR HUT...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE VILLAN: Oh good, you're up.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("!!!!!!!!!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE VILLAIN: Yesterday, I followed you up Mt. Restic to Dr. Q's house. I knew that crazy old coot was up to no good for years... and now I know everything.");
            Console.ReadLine();
            Console.Clear();Console.WriteLine("Why didn't you just come in and talk to him like I did?? Why did you go and rob him?");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("THE VILLAIN: Psh, I don't plan on being friends with that goofy old bat. I want what he has, and I want to rule the world!!!");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("Everywhere I go, people will bow down before me, KING JAX.");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX OPENS HIS BACKPACK, AND YOU CAN SEE HIS X-ORBS! THE OCCULEX SHOWS HIS STATS ON YOUR SCREEN:");
            Console.ReadLine();
            Console.Clear();

            Players jax = new Players();
            jax.playerName = "JAX";
            jax.playerOrbAmount = 3;
            jax.playerStrength = "270 X";
            jax.playerType();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX PULLS OUT A PIECE OF GUM AND STARTS CHEWING LOUDLY, ZIPPING UP HIS BACKPACK AND PUTTING IT BACK ON...");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX: Ya, know... *chew chew chew chew*");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("I was gunna rob you blind - I'm kind of on a hot streak heh... but... *chew chew*");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("I realized, if you had any X-ORBS, they'd be no good to me since they're already linked to your DNA... *chew chew chew*");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("So what do you want from me? Why'd you wait outside of my hut this morning?");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX: To let you know you're not the only player in town. *wink*");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX REACHES BEHIND HIM AND PULLS OUT AN X-ORB... HE STARTS SPINNING VIOLENTLY!!! HE IS NOTHING BUT A BLUR!!");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX: See ya later, sucker!");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("JAX SHOOTS INTO THE GROUND, TUNNELLING FAR FAR INTO THE EARTH, LEAVING BEHIND NOTHING BUT A BLACK HOLE.");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("No!!! God... I .... ugh... I need to call Doc!!!");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("YOU FUMBLE FOR YOUR PHONE AND MANAGE TO FIND HIM IN YOUR CONTACT LIST WITH YOUR SHAKING HAND");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("ring...");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("ring.....");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("ring...");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("ring.....");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();Console.WriteLine("DR Q: Hello??");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Doc! It's me, " + mainChar + "! Listen.. I just ran into " + jax.playerName + " - the guy who robbed you yesterday! He already has more X-ORBS than I do, and he's getting powerful!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR Q: Oh dear... Well, I'm glad we at least know who it is. \nThe only thing I can think to do is to go and find as many X-ORBS as you possibly can before him!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("But Doc, I mean come on man the only way I can find them is by running around like crazy and hoping THE OCCULEX picks something up. Not a real great--");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: Hold on, hold on. I didn't share this with you because I didn't think it was ready... \nbut I have the prototype of an app that shows the coordinates of X-ORBS. \nI won't bore you with the details... Although, it's quite clever if I do say so myself...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I need that, Doc! I don't care if it's not done, that's going to be a MASSIVE help! Can you text me a link or something?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: I'm sending you a link to a shared drive. Open it up and download 'XTRACKER'. \nThe username is DoctorQ, password ... um.... well, the password is 'DoctorQistheman'.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ever the modest one, huh, Doc?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: *ahem* Yes, well, anyway... Let me know if anything else happens. I hope the XTRACKER helps tremendously!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: Thanks, Doc. I will! *click*");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I don't have any time to waste... who knows where Jax is by now... I've gotta use this FLIGHT X-ORB...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU NERVOUSLY PULL THE FLIGHT X-ORB OUT OF YOUR BACKPACK AND STARE AT IT...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How did Doc use his X-ORB to disappear? Didn't he just squee----");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("!!!!! --- WITHIN SECONDS YOU ARE SOARING ABOVE THE TREES OF MT RESTIC! THE X-ORB IS WORKING!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AS YOU SOAR DOWN THE MOUNTAIN, THE TREELINE SOON GIVES WAY TO CONCRETE AND BUILDINGS --- \nYOUR HOMETOWN OF VALORIA.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("LANDING IN YOUR FRONT YARD, YOU FEEL YOUR PHONE VIBRATING IN YOUR POCKET...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What the... it's Doc's app...");
            Console.ReadLine();
            Console.Clear();

            Town valoria = new Town();
            valoria.townName = "VALORIA";
            valoria.orbCount = 7;
            valoria.townType();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It looks like all the X-ORBS are in one area...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU ZOOM IN ON THE MAP IN THE XTRACKER");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The Valoria Catacombs. I wonder if--- w, wait a minute...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Why is there a dot moving on the map??");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("  .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("     .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("       .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("         .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("           .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oh no!! That's probably Jax!!! I gotta get there now before he does!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("But first, I need a hand shovel and a flashlight!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU GRAB A TROWEL AND FLASHLIGHT FROM SHED BEHIND THE HOUSE AND TOSS THEM INTO YOUR BACKPACK.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU GRAB YOUR X-ORB, SQUEEZING IT AS HARD AS YOU CAN, LAUNCH INTO THE SKY, AND HEAD SOUTH TOWARDS THE EDGE OF TOWN WHERE THE CATACOMBS ARE");
            Console.ReadLine();
            Console.Clear();


// LEVEL FOUR -- THE CATACOMBS //


            Console.WriteLine("----THE VALORIA CATACOMBS---- \n----ENTER AT YOUR OWN RISK---- ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Alright. Let's do this!");


bool mazeOne=false;
            
            do 
            {
                Console.WriteLine("LEFT or RIGHT");
                string mazeChoiceOne = Console.ReadLine();
                Console.Clear();
                if(mazeChoiceOne == "r" || mazeChoiceOne == "right" || mazeChoiceOne == "l" || mazeChoiceOne == "left")
                {
                    mazeOne= true;
                
                    switch (mazeChoiceOne)
                    {
                    case "right" or "r" :
                    Console.Clear();

                    break;

                    case "left" or "l" :
                    Console.WriteLine("Hmmm...nothing down there. Let's try the other way.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select Left or Right.");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("Invalid response, please select L or R");
                }
            }
            
            while (mazeOne == false);
            
            Console.WriteLine("That looks like a nice long hallway...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU WALK DOWN THE DARK HALLWAY, SHINING THE FLASHLING ALONG THE WALLS AND INTO THE DARK VOID.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Is it getting darker in here?? ...OH! The OCCULEX!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">DIG");
            Console.ReadLine();
            Console.WriteLine(">>DIG");
            Console.ReadLine();
            Console.WriteLine(">>>DIG");
            Console.ReadLine();
            Console.WriteLine(">>>>DIG");
            Console.ReadLine();
            Console.WriteLine(">>>>>DIG");
            Console.ReadLine();
            Console.WriteLine(">>>>>>DIG");
            Console.ReadLine();
            Console.WriteLine(">>>>>>>DIG");
            Console.ReadLine();
            Console.Clear();

            Orb fire = new Orb();
            fire.orbName = "X-ORB-266...";
            fire.powerType = "FIRE!!";
            fire.strengthLevel = 300;
            fire.orbType();
            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice! I'm sure this will come in handy...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: Yeah, it probably will.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Huh?!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU SPIN AROUND AND SEE JAX HOLDING AN X-ORB!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What do you want, Jax?");
            Console.ReadLine();
            Console.Clear();Console.WriteLine("JAX: I wanna see what this one does...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX HOLDS UP HIS X-ORB AND IT SENDS A BLAST OF WATER RIGHT AT YOU AND KNOCKS YOU DOWN!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("That's it, Jax! It's on!!");
            Console.ReadLine();
            Console.Clear(); 
            Console.Write("HOW MANY FIREBALLS WILL IT TAKE TO BEAT JAX??  ");

            string battleOne = Console.ReadLine();
            int userInput = int.Parse(battleOne);

            if (userInput > 10)
            {
                Console.WriteLine("You beat Jax!!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("JAX: You're lucky I went easy on you!! I won't make the same mistake twice!");
                Console.ReadLine();
                Console.Clear();
            }
            else 
            {
            Console.WriteLine("It wasn't enough... Jax won.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: Hah! That was easier than I thought! Here's a tip for next time: try harder! Catch ya later, loser!");
            Console.ReadLine();
            Console.Clear();
            }

            Console.WriteLine("JAX DISAPPEARS INTO THE CATACOMBS");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I'm glad that's over... I've GOTTA find more X-ORBS!");
            Console.ReadLine();
            Console.Clear();



// LEVEL FIVE -- CATACOMBS AFTER FIRST BATTLE//

            

bool stairsOne=false;
            
            do 
            {
                Console.Write("RUNNING DOWN THE DARK HALLWAY, YOU COME TO A STAIRCASE. GO UP OR DOWN? ");
                string stairChoiceOne = Console.ReadLine();
                Console.Clear();
                if(stairChoiceOne == "u" || stairChoiceOne == "up" || stairChoiceOne == "d" || stairChoiceOne == "down")
                {
                    stairsOne= true;
                
                    switch (stairChoiceOne)
                    {
                    case "up" or "u" :
                    Console.WriteLine("Looks like that'll take me up to ground level... better go down");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                    case "down" or "d" :
                    break;

                    default:
                    Console.WriteLine("Invalid response, please select up or down");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("Invalid response, please select up or down");
                }
            }
            
            while (stairsOne == false);
            

            Console.WriteLine("AS YOU DESCEND THE STAIRCASE, THE CATACOMBS START SHAKING ALL AROUND YOU");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oh #$%* !!!");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("THE STAIRCASE GIVES OUT BENEATH YOU! YOU'RE IN A FREEFALL!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AHHH!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AHHHHH!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AHHHHHHH!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AHHHHHHHH!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AHHHHHHHHHH!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("** THUD **");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AS YOU REGAIN YOUR BEARINGS, YOU HEAR YOUR PHONE BUZZING IN THE DIRT NEXT TO YOU");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NEW NOTIFICATION: XTRACKER");
            Console.ReadLine();
            Console.Clear();

            Town hypocenter = new Town();
            hypocenter.townName = "THE HYPOCENTER";
            hypocenter.orbCount = 1;
            hypocenter.townType();


            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The Hypocenter... I...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("INCOMING CALL FROM DR Q");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello??");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: " + mainChar + "! I was notified you... you are at the Hypocenter?!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("That's what the XTRACKER says... I have no idea what happened -- \nI was walking down a flight of stairs and they gave out -- \nI fell for what felt like an eternity and woke up in this circular room with my phone going off");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: A..... a circular room????");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Yeah it's kind of eerie it's almost perfectly round...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: Dear God. I never thought I'd live to see the day.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What do you mean, Doc??");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: " + mainChar + ", do you have any idea where you are??");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I mean, the hypocenter but, I d----");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: " + mainChar + "! You are at the origin of THE MONOSPHERE!! You are standing right where it burst 100 million years ago!!! If my calculations are right -- if my LIFE'S WORK is correct.....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q GOES QUIET.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Doc???");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: 'Where once there was nothing... \nno darkness or light... \nawaits a new victor... \nfor eternal life...'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Come on, Doc. Now isn't the time for poetry, what's going on?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DR. Q: " + mainChar + "... You will be given the X-ORB of ETERNAL LIFE. But it will only appear to the winner of the battle of GOOD versus EVIL. \nThe victor will live forever...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AS YOU'RE TRYING TO COMPREHEND WHAT DR. Q JUST TOLD YOU... YOU HEAR A GRINDING SOUND...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Doc, hold on a second... I hear something...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I know that sound... where do I know that from?? It sounds like the earth cracking...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("   {           }");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("** THUD **");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A THICK DUST FILLS THE HYPOCENTER");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*silence*");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: So this is it, huh?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Doc, I've gotta go... Jax is here!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: I wonder what that old turd would think if he found out I was granted ETERNAL LIFE");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Huh? I don't know what you're talking about...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: Oh quit the act. I heard everything, thanks to my newest X-ORB SUPERSONIC HEARING. Nice try though.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX PULLS TWO X-ORBS OUT OF HIS BACKPACK");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: Let's dance, buddy!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU GRAB YOUR FIRE X-ORB AND SHOOT A FIRE BALL WITHOUT LOOKING... \nIT MISSES!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX SHOOTS A LASER AT YOU... IT NICKS YOUR FOOT!");
            Console.ReadLine();
            Console.Clear();

bool fightOne=false;
            
            do 
            {
                Console.Write("YOU STAND UP AND SQUARE UP AGAINST HIM, READY TO FIRE. \n\nDO YOU WANT TO AIM AT HIS 1) HEAD 2) CHEST 3) LEGS: ");
                string fightChoiceOne = Console.ReadLine();
                Console.Clear();
                if(fightChoiceOne == "1" || fightChoiceOne == "2" || fightChoiceOne == "3" )
                {
                    fightOne= true;
                
                    switch (fightChoiceOne)
                    {
                    case "1" :
                    Console.WriteLine("It grazed the top of his head, knocking his hat off!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "2" :
                    Console.WriteLine("BAM! A direct hit!! You knocked the wind out of him!!!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "3" :
                    Console.WriteLine("GOT HIM! Nailed him in the left shin!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                }
            }
            
            while (fightOne == false);


            Console.WriteLine("JAX SENDS ANOTHER LASER YOUR WAY... IT MISSES!!");
            Console.ReadLine();
            Console.Clear();


bool fightTwo=false;
            
            do 
            {
                Console.Write("TAKE ANOTHER SHOT!! \n\n1) HEAD 2) CHEST 3) LEGS: ");
                string fightChoiceTwo = Console.ReadLine();
                Console.Clear();
                if(fightChoiceTwo == "1" || fightChoiceTwo == "2" || fightChoiceTwo == "3")
                {
                    fightTwo= true;
                
                    switch (fightChoiceTwo)
                    {
                    case "1" :
                    Console.WriteLine("WHOA! Right smack dab in the face!!! ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "2" :
                    Console.WriteLine("BULLSEYE! Got him!!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "3" :
                    Console.WriteLine("You swept his legs!! He's down for the count!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                }
            }
            
            while (fightTwo == false);


            Console.WriteLine("QUICK! BEFORE HE COMES TO HIS SENSES -- FIRE A QUICK SHOT!");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("Damn, missed just to the right!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX FIRES A WATER BEAM AND A LASER BEAM... THEY CANCEL EACH OTHER OUT!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: Dammit!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX THROWS THE WATER X-ORB TO THE SIDE OF THE ROOM AND GRABS ANOTHER FROM HIS BACKPACK");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU FIRE OFF ANOTHER SHOT...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("HE JUKES LEFT AND DODGES!! JAX SENDS A TORNADO TOWARDS YOU!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("YOU'RE SWEPT UP IN THE TORNADO!! YOU CAN'T FIRE AT HIM!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX TRIES TO HIT YOU WITH HIS LASER, BUT MISSES!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE TORNADO WEARS OFF AND YOU'RE READY TO SHOOT");
            Console.ReadLine();
            Console.Clear();

bool fightThree=false;
            
            do 
            {
                Console.Write("MAKE THIS SHOT COUNT!!! \n\n1) HEAD 2) CHEST 3) LEGS: ");
                string fightChoiceThree = Console.ReadLine();
                Console.Clear();
                if(fightChoiceThree == "1" || fightChoiceThree == "2" || fightChoiceThree == "3")
                {
                    fightThree= true;
                
                    switch (fightChoiceThree)
                    {
                    case "1" :
                    Console.WriteLine("Right in the neck!!! ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "2" :
                    Console.WriteLine("Dead center!! His jacket is on fire!!!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "3" :
                    Console.WriteLine("OOHHHHH!!! A groin shot! Ouch!!!!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                }
            }
            
            while (fightThree == false);

            Console.WriteLine("YOU'RE BOTH GETTING WEAK... DOWN TO THE WIRE!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX FIRES OFF TWO CONSECUTIVE LASERS....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DIRECT HITS ON YOUR LEFT AND RIGHT SHOULDERS!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JAX: You're done for, sucker!!!");
            Console.ReadLine();
            Console.Clear();




bool fightFour=false;
            
            do 
            {
                Console.Write("THIS IS IT! GIVE IT ALL YOUR POWER!! \n\n1) HEAD 2) CHEST 3) LEGS: ");
                string fightChoiceFour = Console.ReadLine();
                Console.Clear();
                if(fightChoiceFour == "1" || fightChoiceFour == "2" || fightChoiceFour == "3")
                {
                    fightFour= true;
                
                    switch (fightChoiceFour)
                    {
                    case "1" :
                    Console.WriteLine("POW! RIGHT IN THE KISSER! JAX GOES DOWN!!! ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "2" :
                    Console.WriteLine("SHOT TO THE HEART! JAX DOUBLES OVER, HOLDING HIS CHEST!!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case "3" :
                    Console.WriteLine("OH NO!!!! YOU MISSED!!!!!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("JAX SENDS A TORNADO AT YOU, AND SHOOTS IT WITH A LASER!! YOU'RE WRAPPED UP IN AN ELECTRIC TORNADO!!!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("JAX: Haha!! You'll never make it out of this alive!!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("THE TORNADO WHIPS YOU AROUND, SHOCKING YOU WITH EVERY SPIN...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("JAX: That should do the trick!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("AS THE TORNADO SUBSIDES, YOU'RE LEFT IN THE CENTER OF THE ROOM, TOO WEAK TO CARRY ON...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("JAX: ETERNAL LIFE is mine!! Muahahaha!!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("YOUR BODY BEGINS TO TURN INTO XEE... SWIRLING AROUND AND AROUND THE ROOM... ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("SLOWLY THE XEE BEGINS TO COMPRESS SMALLER AND SMALLER, UNTIL IT IS AN X-ORB IN THE PALM OF JAX'S HAND");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("ON THE SCREEN OF THE OCCULEX PROTOTYPE STOLEN FROM DR. Q'S HOUSE APPEARS......");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You found X-ORB-01. Its power is ETERNAL LIFE. Half life strength: INFINITE.");
                    Console.ReadLine();
                    Console.Clear();

                    endGame();

                    break;

                    default:
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                    Console.Clear();
                    break;
                    }
                }
                else
                {
                    
                    Console.WriteLine("I'm sorry, I didn't get that. Please select 1, 2, or 3 ");
                }
            }
            
            while (fightFour == false);

// WINNING ENDING //

                Console.WriteLine("NOW'S YOUR CHANCE! FINISH HIM OFF!!!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("YOU SHOOT ONE FINAL FIREBALL AT JAX...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("HE ERUPTS INTO FLAMES!!!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("A BALL OF FIRE FORMS AND BEGINS TO RISE TO THE CENTER OF THE ROOM...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What the...?!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("IT SPINS SLOWLY AS IT MORPHS FROM ORANGE TO BLUE...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("THE FIRE MADE OF JAX'S BODY IS TURNING INTO PURE XEE!!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("IT BEGINS TO COMPRESS, GETTING SMALLER AND SMALLER, AND DESCENDS INTO THE PALM OF YOUR HAND...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Could this possibly be what I think it is???");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("SUDDENLY, SOMETHING APPEARS ON THE LENS OF THE OCCULEX...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You found X-ORB-01. Its power is ETERNAL LIFE. Half life strength: INFINITE.");
                Console.ReadLine();
                Console.Clear();

                endGame();

            

// END GAME //


        static void endGame()
        {
            Console.WriteLine("-------------THE END-------------\n\n");
            Console.WriteLine("COPYRIGHT 2022 EILERS ALBACETE LLC.");
            Console.ReadLine();
            Console.Clear();
            legendOfTheOrbs();
        }
    }
} 
} 

