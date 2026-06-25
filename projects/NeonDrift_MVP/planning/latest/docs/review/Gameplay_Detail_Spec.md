# Gameplay Detail Spec

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md.
- Visual art reference used: visual communication, composition, asset language, motion art, and hierarchy are translated into implementation-ready fields.
- Gameplay depth score: spec review target 3+; evidence must include trigger, state, rule, HUD feedback, QA acceptance, and implementation-ready feature boundaries.
- Visual richness score: spec review target 3+; evidence must include asset list, VFX event table, typography/icon style, particle/VFX budget, reduced-motion fallback, and performance guardrail.
- Current-stage minimum: gameplay depth 3+ and visual richness 3+.
- Pass/fail: fail if the spec only says fun, polished, neon, challenging, or better visuals without concrete implementation fields.
- Blockers: return to planning when depth or richness is missing from planning sources.

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

- 核心循環是開始短局、左右控制漂移、避開障礙、累積分數、碰撞失敗、立即重試。
- 玩法內容層必須來自 planning：wave objective、boost cell pickup、combo chain、hazard pattern 與短局任務都要有明確規則、HUD 顯示、失敗/成功條件與 QA 驗收。
- 分數由存活時間、近距離閃避與連續控制穩定度組成；失敗必須清楚指出碰撞或離線原因。
- 難度曲線以速度、障礙密度與視覺干擾逐步提高，但不得犧牲玩家對車體與障礙的可讀性。
- 系統契約必須保留 Control System、Speed System、Hazard System、Content Objective System、Scoring System、Failure/Retry System、Feedback System；每個系統需要 input、state、rule、output、dependency 與 success/failure conditions。

## English

- The core loop is start run, steer drifting, avoid hazards, build score, fail on collision, and retry immediately.
- Gameplay content layers must originate from planning: wave objective, boost cell pickup, combo chain, hazard pattern, and short-session missions all need explicit rules, HUD display, success/failure conditions, and QA acceptance.
- Score comes from survival time, near-miss avoidance, and control consistency; failure must clearly show collision or off-line cause.
- Difficulty scales through speed, hazard density, and visual pressure without sacrificing readability of the vehicle and hazards.
- The system contract must preserve Control System, Speed System, Hazard System, Content Objective System, Scoring System, Failure/Retry System, and Feedback System; each system needs input, state, rule, output, dependency, and success/failure conditions.
