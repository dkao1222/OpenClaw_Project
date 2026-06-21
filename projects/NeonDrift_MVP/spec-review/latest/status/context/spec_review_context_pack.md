# Spec Review Context Pack

project_name: NeonDrift_MVP
channel_id: 386b9e33-8429-81b6-9841-f0591bcbc61e
stage: spec_review
policy: compressed context pack

## Decisions

- Spec review is Passed; development starts only from handoffs/spec_review/handoff_to_game_development.md after user confirmation.
- Scope: Unity 6000.0.71f1, iPhone-first NeonDrift MVP, short drift run, readable HUD, immediate retry, privacy/ads/store docs, local build readiness.

## Constraints

- Full docs are for Notion/Git human review; use this compressed context pack plus the current handoff.
- Do not copy all spec review docs into the next prompt; open source docs only for missing implementation detail.
- Preserve safe area, icon contract, operation feel, Prototype Flow Canvas, systems contract, GDD acceptance, compatibility, and performance budget.

## Next Agent Input

- Read handoffs/spec_review/handoff_to_game_development.md first.
- Read status/context/spec_review_context_pack.md second.
- Use listed docs only as fallback.

## Source Paths

- handoffs/spec_review/handoff_to_game_development.md
- status/context/spec_review_context_pack.md
- docs/review/Development_Ready_Spec_Package.md
- docs/review/UI_UX_Detail_Spec.md
- docs/review/Icon_and_Control_Spec.md
- docs/review/HUD_Spec.md
- docs/review/UI_State_Matrix.md
- docs/review/Gameplay_Detail_Spec.md
- docs/review/Control_System_Detail_Spec.md
- docs/review/Speed_Hazard_Detail_Spec.md
- docs/review/Scoring_Failure_Retry_Detail_Spec.md
