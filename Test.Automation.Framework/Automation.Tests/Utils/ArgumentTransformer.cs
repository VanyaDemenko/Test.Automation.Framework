using TechTalk.SpecFlow;

namespace Automation.Tests.Utils
{
    [Binding]
    public static class ArgumentTransformer
    {
        [StepArgumentTransformation(@"(activated|deactivated)")]
        [StepArgumentTransformation(@"(activate|deactivate)")]
        [StepArgumentTransformation(@"(active|inactive)")]
        [StepArgumentTransformation(@"(allocate|do not allocate)")]
        [StepArgumentTransformation(@"(are|are not)")]
        [StepArgumentTransformation(@"(can|can not)")]
        [StepArgumentTransformation(@"(check|uncheck)")]
        [StepArgumentTransformation(@"(confirm|reject)")]
        [StepArgumentTransformation(@"(contains|doesn't contain)")]
        [StepArgumentTransformation(@"(did|did not)")]
        [StepArgumentTransformation(@"(does|does not)")]
        [StepArgumentTransformation(@"(do|do not)")]
        [StepArgumentTransformation(@"(enabled|disabled)")]
        [StepArgumentTransformation(@"(Enable|Disable)")]
        [StepArgumentTransformation(@"(has|doesn't have)")]
        [StepArgumentTransformation(@"(has|has no)")]
        [StepArgumentTransformation(@"(has|has not)")]
        [StepArgumentTransformation(@"(should|should not)")]
        [StepArgumentTransformation(@"(have|have not)")]
        [StepArgumentTransformation(@"(is|is not)")]
        [StepArgumentTransformation(@"(on|off)")]
        [StepArgumentTransformation(@"(present|not present)")]
        [StepArgumentTransformation(@"(Release|Hide)")]
        [StepArgumentTransformation(@"(Select all|Select one)")]
        [StepArgumentTransformation(@"(shown|not shown)")]
        [StepArgumentTransformation(@"(successfully|unsuccessfully)")]
        [StepArgumentTransformation(@"(true|false)")]
        [StepArgumentTransformation(@"(with|without)")]
        [StepArgumentTransformation(@"(ascending|descending)")]
        [StepArgumentTransformation(@"(select|unselect)")]
        [StepArgumentTransformation(@"(selected|unselected)")]
        [StepArgumentTransformation(@"(lock|unlock)")]
        [StepArgumentTransformation(@"(expand|collapse)")]
        [StepArgumentTransformation(@"(Expand|Collapse)")]
        [StepArgumentTransformation(@"(added|removed)")]
        [StepArgumentTransformation(@"(add|remove)")]
        [StepArgumentTransformation(@"(increase|decrease)")]
        [StepArgumentTransformation(@"(pin|unpin)")]
        [StepArgumentTransformation(@"(left|right)")]
        public static bool HasHasNotTransformer(string value)
        {
            string[] positives =
            {
                "should", "has", "have", "shown", "are", "is", "contains", "can", "enabled", "present", "check", "with", "increase",
                "confirm", "do", "does", "active", "allocate", "on", "successfully", "Enable", "activate", "activated", "did",
                "Release", "Select all", "true", "ascending", "select", "lock", "selected", "expand", "Expand", "added", "add", "pin", "left"
            };
            return positives.Any(v => v == value);
        }
    }
}
