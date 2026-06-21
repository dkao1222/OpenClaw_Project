# Stage 10 Context Pack

project_name: NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260621091857
channel_id: 386b9e33-8429-815b-a8f3-c43fc218eef4
stage_agent: game-producer
next_agent: critic
policy: compressed context pack

## Decisions

- Stage 10 deliverables stay inside approved NeonDrift MVP scope.
- Required handoff topics: assembled document list, readiness checklist, known dependencies, unresolved questions, validation evidence.
- Deliverables index: docs/design/Game_Design_Document.md, docs/design/Game_Design_Overview.md, docs/design/Core_Loop_Spec.md, docs/design/Mechanics_Rules.md, docs/design/Scoring_and_Failure_Spec.md, docs/design/Compatibility_and_Performance_Targets.md, docs/design/Art_Audio_Direction.md, docs/production/Development_Readiness_Report.md, plus 1 additional docs in Notion/Git.

## Constraints

- Full docs are for Notion/Git human review; agents should use this compressed context pack plus the current handoff for execution.
- Do not copy full prior documents into downstream prompts. Open full source documents only if a specific missing detail is required.
- Keep iPhone-first, short-session, retry, readable HUD, safe area, touch target, haptics/audio, compatibility, and performance assumptions visible.

## Next Agent Input

- Next agent must read handoffs/planning/10_game-producer_to_critic.md first and status/context/stage10_context_pack.md second. Open full source documents only if the compact pack or handoff is missing a required implementation detail.
- Confirm remaining implementation details in spec review before development starts.

## Source Paths

- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/status/context/stage10_context_pack.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/handoffs/planning/10_game-producer_to_critic.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Game_Design_Document.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Game_Design_Overview.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Core_Loop_Spec.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Mechanics_Rules.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/status/agent_heartbeats/game-producer.md
