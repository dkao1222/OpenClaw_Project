# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622172851
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate Unity implementation after fixing retry reload black screen. GameSessionController must clear static Instance on destroy, runtime bootstrap must rebuild UI after scene reload, QA playthrough trigger must be one-shot, and QA must fail if post-retry screenshot is blank or does not show real UI.
