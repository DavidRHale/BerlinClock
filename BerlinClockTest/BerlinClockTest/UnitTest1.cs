using System;
using Xunit;

namespace BerlinClockTest
{
    public class UnitTest1
    {
        [Fact]
        public void SanityCheck()
        {
            var clock = new BerlinClock.BerlinClock();

            Assert.Equal(1, clock.SendOne());
        }

        [Fact]
        public void SingleMinuteRow_Given0000_ReturnsOOOO()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("00:00:00");

            Assert.Equal("OOOO", berlinTime);
        }

        [Fact]
        public void SingleMinuteRow_Given2359_ReturnsYYYY()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("23:59:59");

            Assert.Equal("YYYY", berlinTime);
        }

        [Fact]
        public void SingleMinuteRow_Given1232_ReturnsYYOO()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("12:32:00");

            Assert.Equal("YYOO", berlinTime);
        }

        [Fact]
        public void SingleMinuteRow_Given1234_ReturnsYYYY()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("12:34:00");

            Assert.Equal("YYYY", berlinTime);
        }

        [Fact]
        public void SingleMinuteRow_Given1235_ReturnsOOOO()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("12:35:00");

            Assert.Equal("OOOO", berlinTime);
        }

        [Fact]
        public void SingleMinuteRow_Given1223_ReturnsYYYO()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateSingleMinuteRow("12:23:00");

            Assert.Equal("YYYO", berlinTime);
        }

        [Fact]
        public void FiveMinuteRow_Given0000_ReturnsOOOOOOOOOOO()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateFiveMinuteRow("00:00:00");

            Assert.Equal("OOOOOOOOOOO", berlinTime);
        }

        [Fact]
        public void FiveMinuteRow_Given2359_ReturnsYYRYYRYYRYY()
        {
            var clock = new BerlinClock.BerlinClock();
            var berlinTime = clock.CalculateFiveMinuteRow("00:00:00");

            Assert.Equal("OOOOOOOOOOO", berlinTime);
        }
    }
}
