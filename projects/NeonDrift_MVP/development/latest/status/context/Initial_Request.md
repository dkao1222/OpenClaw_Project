# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622170513
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate Unity implementation with QA playthrough automation. Add -qaPlaythrough runtime mode that auto-runs Start, left/right steering, game over after the readable survival window, and Retry. QA must produce simulator playthrough video, menu/gameplay/game-over/retry screenshots, and interaction_script.log. QA gates must fail if playthrough evidence is missing or screenshots are blank/low-variance.
