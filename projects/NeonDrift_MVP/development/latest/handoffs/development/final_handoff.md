# Final Development Handoff

```yaml
project_name: NeonDrift_MVP
project_channel_id: 386b9e33-8429-815b-b132-fb63e00fe3a9
output_folder: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/
delivery_status: passed
engine: Unity
unity_project_path: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/unity/NeonDrift/
target_platforms:
  - iOS
  - Android
  - WebGL
source_code:
  - unity/NeonDrift/Assets/Scripts/DriftPlayerController.cs
  - unity/NeonDrift/Assets/Scripts/HazardSpawner.cs
  - unity/NeonDrift/Assets/Scripts/GameSessionController.cs
  - unity/NeonDrift/Assets/Scripts/NeonDriftHud.cs
  - unity/NeonDrift/Assets/Scripts/RuntimeQaProbe.cs
qa_automation:
  - unity/NeonDrift/Assets/Tests/EditMode/NeonDriftEditModeTests.cs
  - unity/NeonDrift/Assets/Tests/EditMode/NeonDrift.EditModeTests.asmdef
  - unity/NeonDrift/Assets/Tests/PlayMode/NeonDriftPlayModeTests.cs
  - unity/NeonDrift/Assets/Tests/PlayMode/NeonDrift.PlayModeTests.asmdef
  - Test assemblies are Editor-only and must not be included in iOS/Android/WebGL player builds.
  - Unity Test Framework EditMode results: status/validation/unity_editmode_test_results.xml
  - Unity Test Framework PlayMode results: status/validation/unity_playmode_test_results.xml
  - Runtime QA probe JSON: status/qa/evidence/runtime_probe.json
build_runner:
  - unity/NeonDrift/Assets/Editor/BuildPipelineRunner.cs
icon_assets:
  - unity/NeonDrift/Assets/Branding/AppIcon.png
  - unity/NeonDrift/Assets/Branding/AppIcon.svg
  - assets/icons/app_icon_manifest.json
  - assets/icons/ios/AppIcon-1024.png
  - assets/icons/android/adaptive-icon-foreground.png
  - assets/icons/web/favicon-32.png
  - status/validation/icon_assets_validation.md
visual_assets:
  - unity/NeonDrift/Assets/Art/Fonts/NeonDriftBitmapFont.png
  - unity/NeonDrift/Assets/Art/Backgrounds/NeonTrackBackground.png
  - unity/NeonDrift/Assets/Art/VFX/NeonDriftVfxSheet.png
  - assets/fonts/typography_manifest.json
  - assets/backgrounds/background_manifest.json
  - assets/vfx/vfx_manifest.json
  - status/validation/visual_assets_validation.md
build_status: pending_unity_editor_validation
requires_user_confirmation: true
context_policy: compressed_context_first
context_pack_path: status/context/development_context_pack.md
next_stage_input_policy: read this handoff first, then read the compact context pack. Open source/code files only if the build runner or validation report needs exact implementation details.
```
