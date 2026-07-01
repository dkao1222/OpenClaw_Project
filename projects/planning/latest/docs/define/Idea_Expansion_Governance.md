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

- project_name: 紫微斗數
- raw_idea: 簡單使用紫微斗數，起到教學，算命的作用，卦象解說
- product_vision: 由 Raw Idea 正規化：簡單使用紫微斗數，起到教學，算命的作用，卦象解說 遊戲概念：讓一般使用者，也可以很簡單使用的紫微斗數算命軟體 必須包含：紫微斗數教學，注意事項 Define 階段可放大構想，但放大的內容必須放在候選方向、假設或建議方向，不可放入已確認需求。
- target_audience_field: 由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。
- core_value_field: 由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。 核心玩法：使用中國人所說的生辰八字，最好是用西曆來換算成農曆，來取得命盤大數據 核心物件：紫微斗數，姓名學，算命 成功條件：可以算命？
- platform_target_field: iOS app first, local iOS simulator build and QA delivery required.
- monetization_direction_field: Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。
- compatibility_target_field: iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.
- output_expectation_field: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.

## Interpretation

- Raw Idea does not strongly define visual spectacle; visual direction must stay candidate-based.
- Raw Idea does not clearly define a repeatable core action; Planning must compare candidate core mechanics.
- Raw Idea does not confirm speed or pressure; pacing must be selected as an assumption or candidate.
- No explicit puzzle/strategy cue was found; depth candidates should focus on mastery, scoring, encounters, and progression unless user approves otherwise.

## Expansion Candidates

### Candidate 1: Readable Action Survival

- source_cue: Raw Idea asks for a game/app concept but does not lock a core mechanic.
- proposed_direction: Player performs one clear repeated action to avoid pressure and earn score/reward while learning risk through visible feedback.
- why_it_fits: This keeps MVP scope buildable while creating a clear input -> risk -> feedback -> retry loop.
- gameplay_impact: Requires visible player movement, approaching threats, near-miss/score feedback, failure reason, and immediate retry.
- visual_experience_impact: Requires a distinct visual grammar for player, hazard, reward, safe space, and feedback states.
- risk: Can become too simple if Planning does not add encounter patterns, reward rules, and mastery signals.
- decision_status: Candidate, not confirmed

### Candidate 2: Timed Pressure Run

- source_cue: Raw Idea needs stronger moment-to-moment pressure; timing pressure is a candidate, not a fact.
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

- Recommended, not confirmed: select one primary repeated action in Planning, then combine Readable Action Survival with Progressive Mastery Challenge to avoid a static or unclear prototype.
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
