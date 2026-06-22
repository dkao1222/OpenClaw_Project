# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622143917
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate the iOS-focused Unity implementation after fixing PlayMode test assembly references. Requirements: PlayMode tests must invoke NeonDriftRuntimeBootstrap through reflection, not direct compile-time reference; use a minimal serialized Main scene plus runtime bootstrap-created gameplay/UI objects; avoid 3D PhysicsModule-only types; keep gameplay visually moving, steerable by UI buttons, start-gated, and compatible with iOS simulator. Build validation must install and launch the simulator app and fail if a NeonDrift crash report is produced. QA must verify button interaction, gameplay motion, steering motion, visible gameplay objects, and no blank/static gameplay screen.
