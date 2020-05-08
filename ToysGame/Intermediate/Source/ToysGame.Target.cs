using UnrealBuildTool;

public class ToysGameTarget : TargetRules
{
	public ToysGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ToysGame");
	}
}
