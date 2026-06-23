# Control System Spec

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

required keywords: control, system, spec

### 範圍
- Control System 只負責讀取左右觸控、維持 drift intent、輸出車體轉向與漂移狀態，不負責分數、障礙生成或 UI 呈現。

### 決策
- 輸入規則是 left zone/right zone 持續按壓控制方向，release 回到中性；所有主要觸控區域必須維持 44x44 pt 以上並避開 safe area。

### 交接重點
- 驗收標準是玩家在 iPhone SE 2/3 與 iPhone 15 上能預測車體反應，失敗原因不可來自隱藏延遲或未標示控制區。

## English

required keywords: control, system, spec

### Scope
- The Control System only reads left/right touch, maintains drift intent, and outputs steering plus drift state; it does not own scoring, hazard spawning, or UI rendering.

### Decisions
- Input rules use sustained press on left and right zones with release returning to neutral; all primary touch zones must remain at least 44x44 pt and avoid safe areas.

### Handoff Notes
- Acceptance requires predictable vehicle response on iPhone SE 2/3 and iPhone 15, with failure never caused by hidden latency or unlabeled control zones.
