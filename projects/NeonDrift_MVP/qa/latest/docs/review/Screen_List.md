# Screen List

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy are translated into implementation-ready fields.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
- Asset sourcing cards read: asset_sourcing/ROUTING.md, OPENGAMEART_USAGE.md, LICENSE_DECISION_MATRIX.md, ASSET_ATTRIBUTION_REGISTER.md, and AUDIO_ASSET_CHECKLIST.md when external art/audio sources are referenced.
- License readiness: third-party assets require exact license, attribution, store decision, implementation path, and QA evidence; GPL/LGPL/CC-BY-SA/unclear licenses are blocked by default for mobile store builds.
- Current-stage minimum: gameplay depth 3+ and visual richness 3+.
- Pass/fail: fail if the spec only says fun, polished, neon, challenging, or better visuals without concrete implementation fields.
- Blockers: return to planning when depth or richness is missing from planning sources.

## Product Experience Alignment

- Product experience cards read: product_experience/ROUTING.md, PRODUCT_EXPERIENCE_RUBRIC.md, FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md.
- First-run clarity target: a human viewer must understand the objective, controllable object, danger, next action, success signal, and failure reason from the first screen and first 10 seconds.
- Feedback/game feel target: every important input, score, collision, near miss, boost, failure, pause, and retry event must specify visual/audio/haptic response and timing.
- Human visual QA target: screenshots and video must be readable without relying on JSON probes or hidden flags.
- Pass/fail: fail if automated UI checks pass but the screen is unreadable, visually inert, confusing, or lacks clear product value.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_DESIGN_LAYERS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md.
- Game Dev Black Book reference used: user-centric reverse deduction, MDA/feeling-to-system mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are translated into spec acceptance.
- GDD structure reference used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into implementation-ready specs.
- Game mechanics reference used: player action, system response, state change, feedback, constraints, and success/failure meaning are explicit.
- Game terminology reference used: important genre, mechanic, level/content, system, UI/feedback, reward, and player terms have player meaning, system meaning, and acceptance.
- System purpose: spec must preserve player value, product value, and non-goals from planning.
- 5W1H summary: spec review target requires What, Why, Who, Where, When, and How for every implementation-facing system.
- Layer coverage: strategy, scope, structure, interaction, and presentation must be represented in implementable detail.
- Implementation handoff readiness: state transitions, formulas, caps, reset conditions, dependencies, config fields, feedback, and QA acceptance must be clear.
- Risks or blockers: return to planning when engineering would need to invent missing system behavior.

## 繁體中文

- Screen List 只定義 Main Menu、Run HUD、Pause、Failure Result、Settings 五個 MVP 畫面，不新增商店、帳號、關卡選擇或 liveops 畫面。
- 每個畫面必須列出 primary action、secondary action、entry condition、exit condition 與 required HUD/status data。
- Acceptance: development 可從本文件建立 Unity scene/state mapping，且每個畫面都有明確進出條件。

## English

- Screen List defines only Main Menu, Run HUD, Pause, Failure Result, and Settings for the MVP, without shop, account, level select, or liveops screens.
- Each screen must list primary action, secondary action, entry condition, exit condition, and required HUD/status data.
- Acceptance: development can create Unity scene/state mapping from this file, with clear entry and exit conditions for every screen.
