using System;

namespace _10_RageExpenses
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            double everyTwoHeadsetsCrashed = lostGamesCount / 2;
            double everyThreeMousesCrashed = lostGamesCount / 3;
            double everyThreeKeyboardCrashed = lostGamesCount / 6;
            double everyThreeDisplayCrashed = lostGamesCount / 12;

            double expenses = (displayPrice * everyThreeDisplayCrashed) + (keyboardPrice * everyThreeKeyboardCrashed) + (mousePrice * everyThreeMousesCrashed) + (headsetPrice * everyTwoHeadsetsCrashed);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

/*
 As a MOBA challenger player, Petar has the bad habit of trashing his PC when he loses a game and of rage quiting. His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count.

Every second lost game, Petar trashes his headset.

Every third lost game, Petar trashes his mouse.

When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.

Every second time, when he trashes his keyboard, he also trashes his display.

You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming equipment.

Input / Constraints

· On the first input line – lost games count – integer in the range [0…1000].

· On the second line – headset price – floating-point number in the range [0…1000].

· On the third line – mouse price – floating-point number in the range [0…1000].

· On the fourth line – keyboard price – floating-point number in the range [0…1000].

· On the fifth line – display price – floating-point number in the range [0… 1000].

Output

· As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".

· Allowed working time / memory: 100ms / 16MB.


Input               Output                      Comment

7

2

3

4

5            Rage expenses: 16.00 lv.       Trashed headset → 3 times  
                                            Trashed mouse → 2 times 
                                            Trashed keyboard → 1 time 
                                            Total: 6 + 6 + 4 = 16.00 lv




 */