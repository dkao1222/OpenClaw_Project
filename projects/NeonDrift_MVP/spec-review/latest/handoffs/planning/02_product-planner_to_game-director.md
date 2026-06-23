# Handoff: product-planner to game-director

from_agent: product-planner
to_agent: game-director
project_name: NeonDrift_MVP
project_channel_id: 382b9e3384298039b171c9b2a60ae644
requires_user_confirmation: true
product_goal: NeonDrift MVP is a mobile-first arcade drift game focused on short readable runs, one-finger control, scoring clarity, and instant restart.
platform_direction: Unity 6000.0.77f1 mobile build for iOS and Android with touch-first UX, safe-area handling, performance budget, and device compatibility review.
target_user: Mobile players age 16-35 who want fast neon racing sessions, immediate feedback, and visible mastery without simulator complexity.
mvp_scope: Core drift loop, basic track set, scoring, restart flow, mobile UI, local metrics hooks, privacy and ads readiness notes, and local Unity build preparation.
non_goals: Multiplayer, account system, live operations, large content pipeline, external controller support, and final store-submission assets.
locked_decisions: Use Stage 02 docs, this handoff, and the compact context pack as the source of truth for product scope and mobile platform direction.
open_questions: Tune drift feel, scoring thresholds, frame-rate targets, supported device floor, ad placement timing, and App Store / Google Play compliance details.

source_paths: docs/planning/Game_Proposal.md; docs/planning/One_Page_Game_Concept.md; docs/planning/MVP_Hypothesis.md; docs/planning/Platform_Direction.md; docs/product/MVP_PRD.md; status/agent_heartbeats/product-planner.md
next_stage_input_policy: read this handoff first, then read the compact context pack. Open listed source paths only if a required detail is missing.
context_pack_path: status/context/stage02_context_pack.md
