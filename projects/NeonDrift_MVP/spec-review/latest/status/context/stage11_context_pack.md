# Stage 11 Context Pack

project_name: NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260621125435
channel_id: 386b9e33-8429-81d3-9ecd-cb103dcf7fa9
stage_agent: critic
next_agent: judge
policy: compressed context pack

## Decisions

- Stage 11 deliverables stay inside approved NeonDrift MVP scope.
- Required handoff topics: critical blockers, non-critical issues, missing files, recommended decision, repair command if needed.
- Deliverables index: docs/review/Planning_Gap_Review.md, docs/review/Planning_Risk_Register.md.

## Constraints

- Full docs are for Notion/Git human review; agents should use this compressed context pack plus the current handoff for execution.
- Do not copy full prior documents into downstream prompts. Open full source documents only if a specific missing detail is required.
- Keep iPhone-first, short-session, retry, readable HUD, safe area, touch target, haptics/audio, compatibility, and performance assumptions visible.

## Next Agent Input

- Next agent must read handoffs/planning/11_critic_to_judge.md first and status/context/stage11_context_pack.md second. Open full source documents only if the compact pack or handoff is missing a required implementation detail.
- Confirm remaining implementation details in spec review before development starts.

## Source Paths

- /home/node/.openclaw/workspace/386b9e33-8429-81b6-9841-f0591bcbc61e/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621130126/project/status/context/stage11_context_pack.md
- /home/node/.openclaw/workspace/386b9e33-8429-81b6-9841-f0591bcbc61e/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621130126/project/handoffs/planning/11_critic_to_judge.md
- /home/node/.openclaw/workspace/386b9e33-8429-81b6-9841-f0591bcbc61e/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621130126/project/docs/review/Planning_Gap_Review.md
- /home/node/.openclaw/workspace/386b9e33-8429-81b6-9841-f0591bcbc61e/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621130126/project/docs/review/Planning_Risk_Register.md
- /home/node/.openclaw/workspace/386b9e33-8429-81b6-9841-f0591bcbc61e/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621130126/project/status/agent_heartbeats/critic.md
