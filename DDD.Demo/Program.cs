using System;

namespace DDD.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Hello();
            
            Console.ReadLine();
        }

        
    }

    public abstract class A
    {
        public void  Hello()
        {
            Console.WriteLine("A ok");
        }
    }

    public class B : A {
        new public void Hello()
        {
            Console.WriteLine("B ok");
        }

    }


    #region ISpecification规约接口
    /// <summary>
    /// 规约接口的定义
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);
    }
    #endregion

    #region Specification
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T candidate);


        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public ISpecification<T> Not(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Add or not 实现类
    public class AndSpecification<T>: CompositeSpecification<T>
    {
        private readonly ISpecification<T> _lefSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this._lefSpecification = left;
            this._rightSpecification = right;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return this._lefSpecification.IsSatisfiedBy(candidate)
                && this._rightSpecification.IsSatisfiedBy(candidate);
        }
    }
    #endregion
}
