using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//Data Access katmanı, CORE'a bağımlıdır. (Referans vermeliyiz.)
    public interface IColorDal : IEntityRepository<Color>
    {

    }
}
