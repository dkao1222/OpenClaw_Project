# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622172348
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate Unity implementation after fixing QA playthrough timing. QA playthrough trigger must be consumed once only, must delay Start long enough to capture menu after Unity splash, must capture gameplay after Start, must capture game-over after failure, and must capture post-retry menu after scene reload. QA must fail if video/screenshots do not prove those state transitions.
