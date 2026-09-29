using Quiz1.Model;
using Quiz1.Repos;
using Quiz1.Repos.Abstraction;

namespace Quiz1.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IStudent student { get;  }
        public ITeachear teachear { get;  }
        public IGenericRepo<Department> department { get;  }
        public ISubject subject { get;  }
        public IClassRoom classroom { get;  }
        public IEnrollment enrollment { get;  }
        public void SaveChange();
    }
}
