using System;
using System.Collections.Generic;

namespace Test1
{
    public class Neuron
    {
        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            Type = type;
            Weights = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        public List<double> Weights { get; }
        public NeuronType Type { get; }
        public double Output { get; private set; }
        
        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            return 0.0;
        }
    }
}
