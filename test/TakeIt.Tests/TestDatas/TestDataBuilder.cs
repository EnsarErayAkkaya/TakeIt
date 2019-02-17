using TakeIt.EntityFrameworkCore;

namespace TakeIt.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly TakeItDbContext _context;

        public TestDataBuilder(TakeItDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}