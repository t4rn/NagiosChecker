using AutoFixture;
using FluentAssertions;
using Moq;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Repositories;
using NagiosChecker.Services;
using System.Collections.Generic;
using Xunit;

namespace NagiosChecker.Tests
{
    public class MsSqlTests
    {
        private readonly Mock<ILogService> _loggerMock;
        private readonly Mock<IMsSqlRepository> _repoMock;
        private readonly MsSqlService _msSqlService;
        private readonly Fixture _fixture;

        public MsSqlTests()
        {
            _loggerMock = new Mock<ILogService>();
            _repoMock = new Mock<IMsSqlRepository>();
            _msSqlService = new MsSqlService(_loggerMock.Object, _repoMock.Object);
            _fixture = new Fixture();
        }

        [Fact]
        public void GetBlockers()
        {
            // Arrange
            int semiBlockerOne = 22;
            int semiBlockerTwo = 24;
            var blockerFirst = new SpWho2Session { SPID = 11, BlkBy = " ." };
            var blockerSecond = new SpWho2Session { SPID = 999, BlkBy = " ." };
            var blockerThird = new SpWho2Session { SPID = 4444, BlkBy = " ." };

            var sessions = new List<SpWho2Session>()
            {
                blockerFirst,
                new SpWho2Session{ SPID = semiBlockerOne, BlkBy = blockerFirst.SPID.ToString() },
                new SpWho2Session{ SPID = semiBlockerTwo, BlkBy = blockerFirst.SPID.ToString() },
                new SpWho2Session{ SPID = 30, BlkBy = semiBlockerOne.ToString() },
                new SpWho2Session{ SPID = 40, BlkBy = semiBlockerTwo.ToString() },
                new SpWho2Session{ SPID = 50, BlkBy = semiBlockerOne.ToString() },

                new SpWho2Session{ SPID = 60, BlkBy = blockerSecond.SPID.ToString() },
                new SpWho2Session{ SPID = 70, BlkBy = blockerSecond.SPID.ToString() },
                blockerSecond,

                new SpWho2Session{ SPID = 80, BlkBy = blockerThird.SPID.ToString() },
                new SpWho2Session{ SPID = 90, BlkBy = blockerThird.SPID.ToString() },
                blockerThird,
                new SpWho2Session{ SPID = 91, BlkBy = blockerThird.SPID.ToString() },
                new SpWho2Session{ SPID = 92, BlkBy = blockerThird.SPID.ToString() },
            };

            _repoMock.Setup(x => x.GetSessions()).Returns(sessions);

            // Act
            IEnumerable<SpWho2Session> blockers = _msSqlService.GetBlockers(sessions);

            // Assert
            blockers.Should().NotBeNullOrEmpty()
                .And.HaveCount(3)
                .And.Contain(new SpWho2Session[] { blockerFirst, blockerSecond, blockerThird });
        }
    }
}
