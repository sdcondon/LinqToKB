﻿using FluentAssertions;
using FlUnit;
using static SCPropositionalLogic.SentenceCreation.SentenceFactory;

namespace SCPropositionalLogic
{
    public static class ImplicationTests
    {
        public static Test CloneComparison => TestThat
            .When(() => new
            {
                Representation1 = new Implication(A, B),
                Representation2 = new Implication(A, B)
            })
            .ThenReturns()
            .And(g => g.Representation1.GetHashCode().Should().Be(g.Representation2.GetHashCode()))
            .And(g => g.Representation1.Equals(g.Representation2).Should().BeTrue())
            .And(g => g.Representation2.Equals(g.Representation1).Should().BeTrue());
    }
}
