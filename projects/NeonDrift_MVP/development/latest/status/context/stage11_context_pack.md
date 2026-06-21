# Stage 11 Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644
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

- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/stage11_context_pack.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/planning/11_critic_to_judge.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/docs/review/Planning_Gap_Review.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/docs/review/Planning_Risk_Register.md
- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/agent_heartbeats/critic.md
