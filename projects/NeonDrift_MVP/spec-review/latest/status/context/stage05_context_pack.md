# Stage 05 Context Pack

project_name: NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260621143447
channel_id: 386b9e33-8429-8189-8eaa-e181b7c82cc8
stage_agent: game-designer
next_agent: level-designer
policy: compressed context pack

## Decisions

- Stage 05 deliverables stay inside approved NeonDrift MVP scope.
- Required handoff topics: core loop rules, systems summary, success/failure conditions, player decision points, constraints for level/content design.
- Deliverables index: docs/design/Core_Gameplay_Loop.md, docs/design/Game_Systems_Overview.md, docs/design/Control_System_Spec.md, docs/design/Speed_System_Spec.md, docs/design/Hazard_System_Spec.md, docs/design/Scoring_System_Spec.md, docs/design/Failure_Retry_System_Spec.md, docs/design/Feedback_System_Spec.md, plus 1 additional docs in Notion/Git.

## Constraints

- Full docs are for Notion/Git human review; agents should use this compressed context pack plus the current handoff for execution.
- Do not copy full prior documents into downstream prompts. Open full source documents only if a specific missing detail is required.
- Keep iPhone-first, short-session, retry, readable HUD, safe area, touch target, haptics/audio, compatibility, and performance assumptions visible.

## Next Agent Input

- Next agent must read handoffs/planning/05_game-designer_to_level-designer.md first and status/context/stage05_context_pack.md second. Open full source documents only if the compact pack or handoff is missing a required implementation detail.
- Confirm remaining implementation details in spec review before development starts.

## Source Paths

- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/status/context/stage05_context_pack.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/handoffs/planning/05_game-designer_to_level-designer.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/docs/design/Core_Gameplay_Loop.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/docs/design/Game_Systems_Overview.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/docs/design/Control_System_Spec.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/docs/design/Speed_System_Spec.md
- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/status/agent_heartbeats/game-designer.md
