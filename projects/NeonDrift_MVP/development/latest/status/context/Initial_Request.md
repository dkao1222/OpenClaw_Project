# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622171909
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate Unity implementation after fixing QA playthrough trigger. QA playthrough must be triggered by persistent app data flag and launch arg fallback, must log QA_PLAYTHROUGH markers, and QA gates must prove Start/gameplay/game-over/retry state transitions with screenshots and video, not just nonblank evidence. If Start is not actually pressed or the screen state does not change, QA must fail and return to build/development.
