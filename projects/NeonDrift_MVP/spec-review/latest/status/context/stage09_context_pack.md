# Stage 09 Context Pack

project_name: NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260621091857
channel_id: 386b9e33-8429-815b-a8f3-c43fc218eef4
stage_agent: audio-designer
next_agent: game-producer
policy: compressed context pack

## Decisions

- Stage 09 deliverables stay inside approved NeonDrift MVP scope.
- Required handoff topics: audio direction, haptic trigger conditions, feedback event map, dependencies and risks.
- Deliverables index: docs/design/Audio_Direction.md, docs/design/Audio_Haptics_Event_Map.md.

## Constraints

- Full docs are for Notion/Git human review; agents should use this compressed context pack plus the current handoff for execution.
- Do not copy full prior documents into downstream prompts. Open full source documents only if a specific missing detail is required.
- Keep iPhone-first, short-session, retry, readable HUD, safe area, touch target, haptics/audio, compatibility, and performance assumptions visible.

## Next Agent Input

- Next agent must read handoffs/planning/09_audio-designer_to_game-producer.md first and status/context/stage09_context_pack.md second. Open full source documents only if the compact pack or handoff is missing a required implementation detail.
- Confirm remaining implementation details in spec review before development starts.

## Source Paths

- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/status/context/stage09_context_pack.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/handoffs/planning/09_audio-designer_to_game-producer.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Audio_Direction.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/docs/design/Audio_Haptics_Event_Map.md
- /home/node/.openclaw/workspace/386b9e33-8429-810b-b9f6-fe509ea46472/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621092508/project/status/agent_heartbeats/audio-designer.md
