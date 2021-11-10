using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    public class Day2 : Day
    {
        public string input = "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,6,19,1,9,19,23,1,6,23,27,1,10,27,31,1,5,31,35,2,6,35,39,1,5,39,43,1,5,43,47,2,47,6,51,1,51,5,55,1,13,55,59,2,9,59,63,1,5,63,67,2,67,9,71,1,5,71,75,2,10,75,79,1,6,79,83,1,13,83,87,1,10,87,91,1,91,5,95,2,95,10,99,2,9,99,103,1,103,6,107,1,107,10,111,2,111,10,115,1,115,6,119,2,119,9,123,1,123,6,127,2,127,10,131,1,131,6,135,2,6,135,139,1,139,5,143,1,9,143,147,1,13,147,151,1,2,151,155,1,10,155,0,99,2,14,0,0";

        public void Run()
        {
            var instructions = input.Split(",").Select(s => Convert.ToInt32(s)).ToArray();
            // beginning instructions
            // replace position 1 with the value 12
            // replace position 2 with the value 2
            instructions[1] = 12;
            instructions[2] = 2;
            // main loop
            for (var index = 0; index < instructions.Length; index += 4)
            {
                var instructionSet = new ArraySegment<int>(instructions, index, 4).ToArray();
                var opcode = instructionSet[0];
                var position1 = instructionSet[1];
                var position2 = instructionSet[2];
                var targetPosition = instructionSet[3];

                var value1 = instructions[position1];
                var value2 = instructions[position2];

                if (opcode == 1)
                {
                    // add
                    instructions[targetPosition] = value1 + value2;
                } else if (opcode == 2)
                {
                    // multiply
                    instructions[targetPosition] = value1 * value2;
                }
                else if ( opcode == 99)
                {
                    // halt - end/break
                    break;
                }
            }

            Console.WriteLine($"value at position 0: {instructions[0]}");
        }
    }
}
