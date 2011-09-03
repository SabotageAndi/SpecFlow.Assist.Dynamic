﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.237
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comparing dynamic sets against tables")]
    public partial class ComparingDynamicSetsAgainstTablesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ComparingDynamicSets.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Comparing dynamic sets against tables", "In order to easier and slicker do assertions\r\nAs a SpecFlow developer\r\nI want to " +
                    "be able to compare a list of dynamic items against a table", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Comparing against an identical table should match")]
        public virtual void ComparingAgainstAnIdenticalTableShouldMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Comparing against an identical table should match", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table1.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table1.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01.24",
                        "1.03"});
            table1.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table1.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 8
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table2.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01.24",
                        "1.03"});
            table2.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table2.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 14
 testRunner.When("I compare the set to this table", ((string)(null)), table2);
#line 20
 testRunner.Then("no set comparison exception should have been thrown");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 column name differ")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void NotMatchingWhen1ColumnNameDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 1 column name differ", new string[] {
                        "ignore"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table3.AddRow(new string[] {
                        "Marcus"});
            table3.AddRow(new string[] {
                        "Albert"});
            table3.AddRow(new string[] {
                        "Gustav"});
            table3.AddRow(new string[] {
                        "Arvid"});
#line 24
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "N"});
            table4.AddRow(new string[] {
                        "Marcus"});
            table4.AddRow(new string[] {
                        "Albert"});
            table4.AddRow(new string[] {
                        "Gustav"});
            table4.AddRow(new string[] {
                        "Arvid"});
#line 30
 testRunner.When("I compare the set to this table", ((string)(null)), table4);
#line 36
 testRunner.Then("an difference exception should be thrown with 2 differences");
#line 37
  testRunner.And("one difference should be on the \'Name\' field of the instance");
#line 38
  testRunner.And("one difference should be on the \'N\' column of the table");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 2 header differ")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void NotMatchingWhen2HeaderDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 2 header differ", new string[] {
                        "ignore"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table5.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table5.AddRow(new string[] {
                        "Albert",
                        "3"});
            table5.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table5.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 42
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Namn",
                        "Ålder"});
            table6.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table6.AddRow(new string[] {
                        "Albert",
                        "3"});
            table6.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table6.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 48
 testRunner.When("I compare the set to this table", ((string)(null)), table6);
#line 54
 testRunner.Then("an difference exception should be thrown with 4 differences");
#line 55
  testRunner.And("one difference should be on the \'Name\' field of the instance");
#line 56
  testRunner.And("one difference should be on the \'Age\' field of the instance");
#line 57
  testRunner.And("one difference should be on the \'Namn\' column of the table");
#line 58
  testRunner.And("one difference should be on the \'Ålder\' column of the table");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when the number of rows are more in the table")]
        public virtual void NotMatchingWhenTheNumberOfRowsAreMoreInTheTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when the number of rows are more in the table", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table7.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table7.AddRow(new string[] {
                        "Albert",
                        "3"});
#line 61
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table7);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table8.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table8.AddRow(new string[] {
                        "Albert",
                        "3"});
            table8.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 65
 testRunner.When("I compare the set to this table", ((string)(null)), table8);
#line 70
 testRunner.Then("an set comparison exception should be thrown");
#line 71
  testRunner.And("the error message for different rows should expect 3 rows for table and 2 rows fo" +
                    "r instance");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
