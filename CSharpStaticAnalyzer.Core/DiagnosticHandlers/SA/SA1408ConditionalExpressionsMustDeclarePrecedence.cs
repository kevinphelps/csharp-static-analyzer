namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1408ConditionalExpressionsMustDeclarePrecedence : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}