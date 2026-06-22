# Initial Request

pipeline: Game Development
project_name: NeonDrift_MVP
source_project_name: NeonDrift_MVP
run_id: notion-NeonDrift_MVP-development-dev-full-20260622160326
stage_range: dev-full
source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/spec_review/handoff_to_game_development.md

## Pipeline Request

Regenerate the iOS-focused Unity implementation after fixing gameplay readability. The previous retry/gameplay screen looked like a black screen and players could not understand how to play. Requirements: visible readable track, explicit objective text, avoid-pink-hazards instruction, visible labels for player and hazard, smaller clearer game-over/retry panel that does not make the scene unreadable, and QA gates for gameplayInstructionReadableVerified plus PlayMode GameplayInstructionReadable. Preserve iOS simulator build/launch smoke and crash report detection.
