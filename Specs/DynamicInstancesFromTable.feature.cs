﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create dynamic objects from SpecFlow table")]
    public partial class CreateDynamicObjectsFromSpecFlowTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DynamicInstancesFromTable.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create dynamic objects from SpecFlow table", "\tIn order to write only code that matters\r\n\tAs a SpecFlow developer\r\n\tI want Spec" +
                    "Flow to create dynamic objects from a table row", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row")]
        public virtual void CreateDynamicInstanceFromTableWithOneRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row", ((string[])(null)));
#line 6
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
#line 7
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table1, "When ");
#line 10
 testRunner.Then("the Name property should equal \'Marcus\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
  testRunner.And("the Age property should equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("the BirthDate property should equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("the LengthInMeters property should equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2Columns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 16
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table2, "When ");
#line 19
 testRunner.Then("the Name property should equal \'Marcus\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
  testRunner.And("the Age property should equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table3.AddRow(new string[] {
                        "Age",
                        "39"});
            table3.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table3.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 23
 testRunner.When("I create a dynamic instance from this table", ((string)(null)), table3, "When ");
#line 29
 testRunner.Then("the Name property should equal \'Marcus\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
  testRunner.And("the Age property should equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("the BirthDate property should equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("the LengthInMeters property should equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
