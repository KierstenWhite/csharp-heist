using System;
using System.Collections.Generic;

/*
Notes from Tommy's Review:
- Could have used a double instead of decimal because a double takes less places past the decimal and less memory
*/

namespace Heist
{
    public class ThePlan
    {
        // Create a way to store a single team member. A team member will have a name, a skill Level, and a courage factor.
        public class TeamMember
        {
            public string Name { get; set; }
            // The skill Level will be a positive integer
            public int SkillLevel { get; set; }
            // and the courage factor will be a decimal between 0.0 and 2.0.
            public decimal CourageFactor { get; set; }
        }

        static void Main(string[] args)
        {
            // Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");

            // Create a way to store several team members.
            List<TeamMember> teamMembers = new List<TeamMember>();

            // Declare the variable outside the loop to make it accessible
            // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            Console.WriteLine("Enter your bank difficulty level (out of 100):");
            int userInputtedBankDifficultyLevel = int.Parse(Console.ReadLine());

            while (true)
            {

                // Prompt the user to enter a team member's name and save that name.
                Console.WriteLine("Please enter a team member's name:");
                string teamMemberName = Console.ReadLine();

                // Stop collecting team members when a blank name is entered.
                if (string.IsNullOrEmpty(teamMemberName))
                    break;

                // Prompt the user to enter a team member's skill level and save that skill level with the name.
                Console.WriteLine("Enter the team member's skill (should be a positive integer):");
                int teamMemberSkillLevel = int.Parse(Console.ReadLine());

                // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                Console.WriteLine("Enter the team member courage factor (should be a decimal between 0.0 - 2.0):");
                decimal teamMemberCourageFactor = decimal.Parse(Console.ReadLine());


                // Create a new object that stores all the Team Member information
                TeamMember teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                // Collect several team members' information. - I think this is what this does
                teamMembers.Add(teamMember);

                Console.WriteLine("Heist Team Member Added");
                Console.WriteLine("----------------------------");
            }

            // Display a message containing the number of members of the team.
            Console.WriteLine($"You have {teamMembers.Count} Team Members:");
            Console.WriteLine("----------------------------");

            // Display each team member's information.
            // foreach (var member in teamMembers)
            //     Console.WriteLine($"{member.Name}, Skill Level: {member.SkillLevel}, Courage Factor: {member.CourageFactor}");

            // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
            Console.WriteLine("Enter the number of trial runs you'd like to perform:");
            int trialRuns = int.Parse(Console.ReadLine());
            int successfulRuns = 0;
            int failedRuns = 0;

            // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
            for (int i = 0; i < trialRuns; i++)
            {
                // Sum the skill levels of the team. Save that number.
                int totalTeamSkillLevel = 0;

                // Compare the number with the bank's difficulty level.
                foreach (var member in teamMembers)
                {
                    totalTeamSkillLevel += member.SkillLevel;
                }

                // Create a random number between -10 and 10 for the heist's luck value.
                int randomLuckValue = new Random().Next(-10, 10);
                // Store a value for the bank's difficulty level. Set this value to 100.
                int bankDifficulty = userInputtedBankDifficultyLevel + randomLuckValue; // Add random luck number to the bank's difficulty level.

                Console.WriteLine($"Trial {i + 1}:");
                Console.WriteLine($"The team's combined skill level is {totalTeamSkillLevel}. The bank's difficulty level is {bankDifficulty}.");

                if (totalTeamSkillLevel >= bankDifficulty)
                {
                    Console.WriteLine("Your team's skill level is enough to complete this bank job!");
                    successfulRuns++;
                }
                else
                {
                    Console.WriteLine("Your team's total skill level is too low to complete this bank job.");
                    failedRuns++;
                }

                Console.WriteLine("----------------------------");
            }
            //At the end of the program, display a report showing the number of successful runs and the number of failed runs.
            Console.WriteLine($"You had {successfulRuns} sucessful runs and {failedRuns} failed runs.");
        }
    }
}
