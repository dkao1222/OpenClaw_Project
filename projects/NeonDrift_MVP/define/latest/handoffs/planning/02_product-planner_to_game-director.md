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

source_paths: docs/planning/Game_Proposal.md; docs/planning/proposal/High_Concept.md; docs/planning/proposal/Game_Screen_Outline.md; docs/planning/proposal/First_10_Seconds.md; docs/planning/proposal/Primary_Objects_and_Rules.md; docs/planning/proposal/Failure_Retry_and_Progress.md; docs/planning/proposal/MVP_Boundary_and_Success.md; docs/planning/Game_Objective.md; docs/planning/One_Page_Game_Concept.md; docs/planning/concept/Product_Vision_and_Audience.md; docs/planning/concept/Core_Value_and_MVP_Summary.md; docs/planning/concept/Experience_Promise.md; docs/planning/Core_Gameplay_Loop.md; docs/planning/core_loop/Loop_Timeline.md; docs/planning/core_loop/Player_Actions.md; docs/planning/core_loop/Feedback_Rhythm.md; docs/planning/core_loop/Failure_Return.md; docs/planning/Player_Interaction_Model.md; docs/planning/Gameplay_Depth_Target.md; docs/planning/Visual_Richness_Target.md; docs/planning/Planning_Output_Quality_Bar.md; docs/planning/MVP_Hypothesis.md; docs/planning/hypothesis/Risk_Hypotheses.md; docs/planning/hypothesis/Validation_Methods.md; docs/planning/hypothesis/Success_Metrics.md; docs/planning/hypothesis/Decision_Rules.md; docs/planning/Platform_Direction.md; docs/planning/platform/Device_Compatibility_Targets.md; docs/planning/platform/Input_and_Safe_Area_Model.md; docs/planning/platform/Build_and_QA_Environment.md; docs/product/MVP_PRD.md; status/agent_heartbeats/product-planner.md
next_stage_input_policy: read this handoff first, then read the compact context pack. Open listed source paths only if a required detail is missing.
context_pack_path: status/context/stage02_context_pack.md
