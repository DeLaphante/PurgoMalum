using CynkyHook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reqnroll;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.ClassLevel)]
namespace PurgoMalum.Configuration
{
    [Binding]
    class Hooks
    {
        Config _Config;
        FeatureContext _FeatureContext;
        ScenarioContext _ScenarioContext;

        Hooks(ScenarioContext scenarioContext)
        {
            _FeatureContext = scenarioContext.ScenarioContainer.Resolve<FeatureContext>();
            _ScenarioContext = scenarioContext.ScenarioContainer.Resolve<ScenarioContext>();
            _Config = scenarioContext.ScenarioContainer.Resolve<Config>();
        }

        [BeforeTestRun]
        static void InitializeReport()
        {
            Config.InitializeReport();
        }

        [BeforeScenario]
        void Launch()
        {
            _Config.Launch(_FeatureContext, _ScenarioContext, null, null);
        }

        [BeforeFeature]
        static void BeforeFeature(FeatureContext featureContext)
        {
            Config.BeforeFeature(featureContext);
        }

        [AfterScenario]
        void AfterScenario()
        {
            _Config.AfterScenario(_ScenarioContext);
        }

        [AfterStep]
        void Steps()
        {
            _Config.Steps(_FeatureContext, _ScenarioContext);
        }

        [AfterTestRun]
        static void TearDownReport()
        {
            Config.TearDownReport();
        }
    }
}
