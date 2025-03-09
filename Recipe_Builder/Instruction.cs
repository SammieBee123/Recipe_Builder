using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{
    [Serializable]
    public class Instruction
    {
        [JsonProperty("analyzedInstructions[steps[number]]")]
        public int Number { get; set; }

        [JsonProperty("analyzedInstructions[steps[step]]")]
        public InstructionList step { get; set; }
    }
}