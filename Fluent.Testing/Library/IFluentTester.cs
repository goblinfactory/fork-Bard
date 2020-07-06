using Fluent.Testing.Library.Then;
using Fluent.Testing.Library.When;

namespace Fluent.Testing.Library
{
    public interface IFluentTester
    {
        IWhen When { get; }
        IThen Then { get; }
    }
}