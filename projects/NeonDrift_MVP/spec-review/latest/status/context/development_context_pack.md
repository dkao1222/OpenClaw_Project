# Development Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644
stage: development
policy: compressed context pack

## Decisions

- Development delivery is Passed and build is monitor-only until the user confirms local Unity editor readiness.
- Unity project path is /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift/ and target platforms remain iOS, Android, and WebGL.
- MVP source includes drift controller, hazard spawner, session controller, HUD, build runner, app icon assets, font/background/VFX visual assets, legal/privacy docs, QA docs, and final handoff.

## Constraints

- Full docs are for Notion/Git human review; local build agents should use this compressed context pack plus handoffs/development/final_handoff.md.
- Watcher must not launch Unity automatically. Build row remains not start until the user manually changes it to processing.
- Preserve Unity 6000.0.77f1 direction, mobile safe area, immediate retry, readable HUD, privacy/ads compliance, and local build reports.

## Build Input

- Read handoffs/development/final_handoff.md first.
- Read status/context/development_context_pack.md second.
- Open source/code files only when the build runner or validation report needs exact implementation details.

## Source Paths

- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/development/final_handoff.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/development_context_pack.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift/Packages/manifest.json
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift/ProjectSettings/ProjectVersion.txt
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift/Assets/Editor/BuildPipelineRunner.cs
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift/Assets/Branding/AppIcon.png
- Additional source docs stay in Notion/Git; open only if required detail is missing.
