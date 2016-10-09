using System;
using CSharpGuidelinesAnalyzer.ClassDesign;
using CSharpGuidelinesAnalyzer.Test.TestDataBuilders;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Xunit;

namespace CSharpGuidelinesAnalyzer.Test.Specs.ClassDesign
{
    public class DoNotExposeStatefulObjectsThroughStaticMembersSpecs : CSharpGuidelinesAnalysisTestFixture
    {
        protected override string DiagnosticId => DoNotExposeStatefulObjectsThroughStaticMembersAnalyzer.DiagnosticId;

        protected override DiagnosticAnalyzer CreateAnalyzer()
        {
            return new DoNotExposeStatefulObjectsThroughStaticMembersAnalyzer();
        }

        protected override CodeFixProvider CreateFixProvider()
        {
            throw new NotImplementedException();
        }
    }
}