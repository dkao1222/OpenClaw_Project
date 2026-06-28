# Idea Expansion Governance

## Policy

Define Idea Expansion Governance:
- Define may expand a raw idea only as labeled interpretation, assumption, candidate, or recommended-not-confirmed direction.
- Define must not promote invented gameplay, genre, story, platform, monetization, visual direction, success metric, or target audience into Confirmed Requirements unless the Raw Idea explicitly states it.
- Every Expansion Candidate must include: source cue from Raw Idea, proposed product/game direction, why it fits, gameplay impact, visual/experience impact, risk, and decision status.
- Recommended Direction is allowed, but it must be labeled Recommended, not confirmed.
- Planning may use candidates for comparison and synthesis, but must keep the candidate provenance visible in planning documents and handoffs.
- If Raw Idea is too thin, Define should still provide candidate directions, but Planning must mark the selected direction as assumption-backed instead of confirmed.

## Confirmed Requirements

- project_name: NeonDrift_MVP
- raw_idea: Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel. The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention. The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score. The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry. The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks. Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts. Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame. Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.
- product_vision: 由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel. The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention. The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score. The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry. The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks. Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts. Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame. Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check. 遊戲概念：Neon arcade drift runner: the player pilots a glowing hover car in a moving light tunnel, making quick left/right drift decisions under pressure. 玩家目標：Survive the run, avoid hazard shards, collect boost cells, chain near misses/combo score, and beat the best score with fast retry. 必須包含：Start menu, Settings/Sound, best score, left/right touch controls, moving player vehicle, track/background motion, hazards, boost
- target_audience_field: 由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。
- core_value_field: 由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。 核心玩法：Tap/hold left or right to drift between lanes while the track scrolls. Hazards damage/end the run, boosts restore pulse and score, and retry must restart a fresh moving run. 核心物件：Player hover car, neon track/lane rails, hazard shards, boost cells, score/combo/pulse HUD, pause, failure overlay with reason, retry button. 視覺方向：High-contrast neon arcade style with moving background layers, visible vehicle silhouette, cyan/magenta hazard-reward language, glow trails, readable HUD, and safe-area aware controls. 成功條件：QA must provide screenshots/video proving Start, moving gameplay, left/right control response, hazard, boost, score/pulse change, failure reason, retry reset, visual richness, and non-placeholder style frames. QA 要求：QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.
- platform_target_field: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- monetization_direction_field: Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.
- compatibility_target_field: iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.
- output_expectation_field: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input. References: Use OpenClaw knowledge bases for Apple HIG, product experience, game quality, game system design, visual richness, and OpenGameArt-compatible asset direction. QA Requirement: QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.

## Interpretation

- Raw Idea contains neon/light/cyber cues; Define interprets visual spectacle as a likely experience goal, not a confirmed art direction.
- Raw Idea contains drift/sliding cues; Define interprets player control, inertia, and risk-reward movement as likely design space.
- Raw Idea suggests speed, reaction, or rhythm pressure; this supports time-pressure candidates but does not confirm exact pacing.
- No explicit puzzle/strategy cue was found; depth candidates should focus on mastery, scoring, encounters, and progression unless user approves otherwise.

## Expansion Candidates

### Candidate 1: Skill Drift Survival

- source_cue: Raw Idea includes drift/sliding language.
- proposed_direction: Player repeatedly drifts left/right through a readable lane/track space, avoids moving hazards, and builds score through near-miss skill.
- why_it_fits: This keeps MVP scope buildable while creating a clear input -> risk -> feedback -> retry loop.
- gameplay_impact: Requires visible player movement, approaching threats, near-miss/score feedback, failure reason, and immediate retry.
- visual_experience_impact: Can use neon contrast, track glow, pulse feedback, hazard silhouettes, and layered speed lines to make risk readable.
- risk: Can become too simple if Planning does not add encounter patterns, reward rules, and mastery signals.
- decision_status: Candidate, not confirmed

### Candidate 2: Rhythm Pressure Run

- source_cue: Raw Idea suggests speed/reaction/rhythm.
- proposed_direction: Player acts on timed pulses/windows; correct timing grants combo/boost, late or wrong action increases danger.
- why_it_fits: This can amplify product feeling and give QA clear timing evidence.
- gameplay_impact: Requires pulse window, readable countdown/cue, success/failure timing feedback, combo break, and recovery moments.
- visual_experience_impact: Needs beat/pulse animation, screen flash discipline, audio/haptic cue mapping, and non-overlapping HUD feedback.
- risk: Higher implementation and QA cost; can feel unfair if timing windows and readability are not specified.
- decision_status: Candidate, not confirmed

### Candidate 3: Progressive Mastery Challenge

- source_cue: Raw Idea likely needs replay value and depth beyond a passive score timer.
- proposed_direction: The MVP adds staged hazard patterns, combo rules, simple unlock/progression, and post-run feedback so each retry teaches a new skill.
- why_it_fits: This addresses the previous pipeline failure mode where gameplay looked static or too shallow.
- gameplay_impact: Requires at least three encounter patterns, score formula, reward/penalty, tutorial beat, and difficulty ramp.
- visual_experience_impact: Requires differentiated hazards/rewards, mastery feedback, and increasingly rich but still readable screen states.
- risk: Can overgrow MVP if Planning does not lock scope and cut non-essential systems.
- decision_status: Candidate, not confirmed

## Recommended Direction

- Recommended, not confirmed: combine Skill Drift Survival with Progressive Mastery Challenge for MVP; use Rhythm/Timed Pressure only if Planning can keep controls readable and QA-testable.
- decision_status: Recommended, not confirmed

## Open Questions

- Which Expansion Candidate should be treated as the MVP direction, or should Planning compare all candidates first?
- What is the strongest intended player feeling: speed, mastery, tension, relaxation, strategy, collection, or spectacle?
- Which visual references are approved, and which are only inspirational?
- What must be excluded from MVP scope even if it would increase depth or polish?
- What is the minimum acceptable device/OS compatibility target for release, not only simulator testing?

## Downstream Rules

- Planning must compare or explicitly select candidates with rationale.
- Planning must preserve confirmed/assumption/candidate/open-question labels.
- Spec Review must convert the selected candidate into concrete implementation specs only after Planning records its rationale.
- Development must not implement unselected candidates unless a later OPDCA/DMAIC remediation explicitly changes scope.
