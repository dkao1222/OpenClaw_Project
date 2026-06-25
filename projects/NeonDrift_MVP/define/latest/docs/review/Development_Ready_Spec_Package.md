# Development Ready Spec Package

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

- MVP 範圍鎖定為單人 mobile neon drift prototype：開始、遊玩、失敗、分數、重試與基本設定。
- 開發任務應拆成 project shell、core loop、UI/HUD、visual audio feedback、QA pass 與 final package。
- Acceptance criteria / 完成標準是玩家能在手機上完成一輪短局、理解失敗原因、看到分數回饋，並可立即重試。
- Source gate: Moment_to_Moment_Gameplay.md、Enemy_Pattern_Spec.md、Player_Skill_Reward_Spec.md、Human_Playtest_Scenarios.md、Operation_Flow_Diagram.md、Prototype_Flow_Canvas.html、Game_Systems_Overview.md、Game_Design_Document.md 必須通過規格標記，development 不可使用舊版籠統 planning。
- Game-quality implementation gate: 10-second playability timeline、三個 enemy/hazard pattern、player skill/reward rule、human playtest pass/fail rule 必須轉成 state/input/rule/output/feedback/QA acceptance。
- Define contract gate: development 不可覆寫 Game Design Foundation Contract、Core Mechanics、Game Loop、Systems and Tuning、Level Design、Human Playability Contract、Visual Richness Contract、Interaction and State Contract、Audio Feedback Contract 或 Evidence Contract；若缺失任何一項，spec review 必須 blocked。
- Compatibility Matrix: MVP 以 iPhone-first 為主，最低 iOS 15+，必測 iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro；次要驗證 Android 10+ 代表機與 WebGL desktop browser，並記錄 aspect ratio 與 performance budget。

## English

- The MVP scope is a single-player mobile neon drift prototype covering start, play, failure, score, retry, and basic settings.
- Implementation should be split into project shell, core loop, UI/HUD, visual-audio feedback, QA pass, and final package.
- Acceptance criteria: a mobile player can finish a short run, understand failure, see score feedback, and retry immediately.
- Source gate: Moment_to_Moment_Gameplay.md, Enemy_Pattern_Spec.md, Player_Skill_Reward_Spec.md, Human_Playtest_Scenarios.md, Operation_Flow_Diagram.md, Prototype_Flow_Canvas.html, Game_Systems_Overview.md, and Game_Design_Document.md must pass required markers; development must not use older vague planning.
- Game-quality implementation gate: the 10-second playability timeline, three enemy/hazard patterns, player skill/reward rules, and human playtest pass/fail rules must become state/input/rule/output/feedback/QA acceptance.
- Define contract gate: development cannot override the Game Design Foundation Contract, Core Mechanics, Game Loop, Systems and Tuning, Level Design, Human Playability Contract, Visual Richness Contract, Interaction and State Contract, Audio Feedback Contract, or Evidence Contract; missing any item must block spec review.
- Compatibility Matrix: the MVP is iPhone-first with minimum iOS 15+, required checks on iPhone SE 2/3, iPhone 12/13 mini, and iPhone 15/15 Pro; secondary checks cover representative Android 10+ devices and WebGL desktop browsers, with aspect ratio and performance budget recorded.
