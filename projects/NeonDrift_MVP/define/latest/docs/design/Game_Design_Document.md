# Game Design Document

Document contract: this file records only the current stage decision surface for the next planning owner. Do not copy full prior documents, and keep each subsection compact.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md; use GAMEPLAY_DEPTH.md and VISUAL_RICHNESS.md when this file affects gameplay or presentation.
- Gameplay depth score: target 3 when this file owns game systems, GDD, mechanics, content, or production readiness; otherwise inherited from upstream planning.
- Gameplay depth evidence: short-session objective, player decision, risk/reward, combo, boost, wave/phase, hazard pattern, failure reason, HUD feedback, and QA acceptance must be explicit before development.
- Visual richness score: target 3 when this file owns visual direction, art/audio, feedback, GDD, or production readiness; otherwise inherited from upstream planning.
- Visual richness evidence: visual richness target, minimum polish bar, background layers, track materials, typography style, icon style, motion polish, particle/VFX budget, reduced motion fallback, and performance target must be explicit before development.
- Current-stage minimum: planning final requires gameplay depth 3+ and visual richness 3+.
- Blockers: fail the stage if depth/richness is described only as fun, polished, neon, or challenging without concrete rules, assets, event feedback, and acceptance criteria.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, SYSTEM_DESIGN_LAYERS.md, DESIGN_METHODS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md when this file affects game systems.
- System purpose: every system must state player value, product value, and non-goals before spec review.
- 5W1H summary: What, Why, Who, Where, When, and How must be explicit for gameplay systems, content, activities, rewards, and GDD rules.
- Layer coverage: strategy, scope, structure, interaction, and presentation must be covered before development.
- Implementation handoff readiness: state, input, output, rule, dependency, feedback, edge case, config, and QA acceptance must be present.
- Risks or blockers: fail the stage if a system requires engineering to invent missing behavior.

## 繁體中文

required keywords: game, design, document

### 範圍
- MVP 範圍是 iPhone-first 單人 NeonDrift 短局遊戲：主選單、開始、漂移操控、速度風險、分數、碰撞失敗、重試與基本設定。

### 決策
- 核心循環是 Start Run -> 左右操控漂移 -> 避開障礙與維持賽道線 -> 以存活時間、近距離閃避與穩定控制累積分數 -> failure -> Retry；Compatibility Matrix 必須涵蓋 iOS 15+、iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro、Android 10+ 代表機與 WebGL desktop browser。

### 交接重點
- 玩法內容深度必須在 planning 鎖定：Wave Objective、Boost Cell、Combo Chain、Hazard Pattern、短局任務與失敗原因提示都要有規劃來源，development 不可自行臨時新增核心玩法。

## English

required keywords: game, design, document

### Scope
- The MVP scope is an iPhone-first single-player NeonDrift short-session game: main menu, start, drift control, speed risk, score, collision failure, retry, and basic settings.

### Decisions
- The core loop is Start Run -> steer drifting -> avoid hazards and stay readable on the racing line -> score through survival time, near misses, and control consistency -> failure -> Retry; the Compatibility Matrix must cover iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, representative Android 10+ devices, and WebGL desktop browsers.

### Handoff Notes
- Gameplay content depth must be locked during planning: Wave Objective, Boost Cell, Combo Chain, Hazard Pattern, short-session missions, and failure reason hints need planning sources; development must not invent core gameplay ad hoc.
