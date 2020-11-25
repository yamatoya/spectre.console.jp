using Statiq.Common;
using Statiq.Core;
using Statiq.Web.GitHub;

namespace Docs.Pipelines
{
    public class DeploymentPipeline : Pipeline
    {
        public DeploymentPipeline()
        {
            Deployment = true;
            OutputModules = new ModuleList
            {
                new DeployGitHubPages(
                    Config.FromSetting<string>(Constants.Site.Owner),
                    Config.FromSetting<string>(Constants.Site.Repository),
                    "8716ca8c9f915797196ef33cbfad80e19493dce8")
                        .ToBranch(Config.FromSetting<string>(Constants.Deployment.TargetBranch))
            };
        }
    }
}
