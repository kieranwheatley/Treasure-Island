using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class Description
    {
        private string[,] description = new string[5, 5];
        public Description()
        {
            description[0, 0] = "You come come to the base of a volcano, smoke pouring from the top.\nThe sea crashes around the sides, there's no way past it.";
            description[0, 1] = "You're on the Western shoreline, the waves gently lapping at the beach.\nTo the East there are cables and metal hanging from the trees.\nTo the South, more shoreline.";
            description[0, 2] = "The Western shoreline stretches North and South. To the East you can see\nwhat looks like a cockit of a plane stickigng out of the treeline.";
            description[0, 3] = "You come to the end of the Western shoreline. To the North, the beach\nstretches on. To the South, you can see some rotting wooden\npillars around rocks. To the East, the Jungle teems with life.";
            description[0, 4] = "You arrive at what appears to be an old mine entrance that has caved in.\nYou can see no way through. To the North, the Western shoreline\nstretches out before you. To the East, there is a cliff face overlooking the sea.";
            description[1, 0] = "You find yourself stood in the golden sand dunes of the North beach.\nIt carries on to the East. You can see something that looks like a\nparachute hanging from the jungle trees to the South and smoke pours into the sky from the West.";
            description[1, 1] = "You come across the rear end of an old, rusted passenger plane. It's must have\ncrashed here, taking out some of the jungle's trees with it.\nYou can see more to the South. The Jungle thickens to the East\nand to the North and West you can hear waves.";
            description[1, 2] = "The cockpit of a plane is half buried in the Earth. The doors have rusted shut\nand you can see what looks like a human skeleton through the window.\nThe rear of the plane facing the North whilst the Jungle\ncontinues to the East and South.\nYou can see seagulls to the West.";
            description[1, 3] = "The trees are becoming few and far between to the West and South but gets deeper to the East.\nThe jungle must end soon. The sunlight reflects\noff something to the North.";
            description[1, 4] = "You're stood atop a cliff edge, the sea wildly crashing into the walls.\nThe cliff stretches to the East as far as you can see. The Jungle invites you in to the North\nand to the West, rocks have been piled up haphazardly.";
            description[2, 0] = "You're stood on the sand dunes of the Northern beach. The beach stretches\nto the West. To the East and South, the jungle surrounds you.\nTo the West, the beachs continues.";
            description[2, 1] = "You find the jungle is less dense to the North. It surrounds every other direction.\nYou can see scraps of metal to the South.";
            description[2, 2] = "You find yourself stood in the middle of the jungle.\nThe jungle surrounds you from each direction.\nYou can see the wooden pillars to the East, and airplane seats to the West.";
            description[2, 3] = "You're still surrounded by the jungle to North, West, and East.\nThrough the last few trees in the South, you can hear waves.";
            description[2, 4] = "You stumble on the cliff edge, catching your footing at the last moment.\nThe cliff continues East and West as far as you can see.\nYou can feel the heat of the jungle to the North.";
            description[3, 0] = "You're in the Jungle, which becomes too dense and dark to advance further North.\nIt continues to the East and South. There is sand on\nthe floor that increases to the West.";
            description[3, 1] = "Birds fly between the trees above you, singing with each other. The canopy of the jungle\nspreads North and West. To the East you can smell the ocean.\nYou can see some wooden huts to the South.";
            description[3, 2] = "You stand between some old wooden huts and a huge gate covering a cave entrance.\nA huge chain seals the gate closed. You can see a beach to the East.\nThe jungle surrounds you from all other directions.";
            description[3, 3] = "You're stood in a small river in the jungle, the gentle flowing water cooling you.\nThe water is running North into the jungle, that continues East as well.\nThe river is flowing from the East, where you can see a glimpse of\nthe ocean. To the South, you can see rocks.";
            description[3, 4] = "You're stood on the cliff edge which stretches upwards West. The cliff descends into the Sea and the jungle is North.";
            description[4, 0] = "You cannot move further North or East as the jungle becomes almost pitch black\nand the trees become to close and dense. You can see a beach to the South and the Jungle thins to the West.";
            description[4, 1] = "You're stood on the beach, with the sun in your eyes. The jungle grows from the\nNorth and West. To the South, you can see items sticking out of the sand.";
            description[4, 2] = "You are surrounded by mostly junk scattered across the beach.\nThe beach continues to the North and South. To the West, you can see wooden huts.";
            description[4, 3] = "You stand on the edge of the water. The beach sprawls North.\nTrees line the West and to the South there are some flat rocks.";
            description[4, 4] = "You're standing on rocks in water. However, the waves are getting stronger.\nThe rocks rise us to the West into a cliff. A beach spreads to the North.";
        }

        public string getDescription(Player player)
        {
            int x = player.getPlayerX();
            int y = player.getPlayerY();
            return description[x, y];
        }
    }
}
