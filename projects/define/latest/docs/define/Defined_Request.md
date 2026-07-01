# Defined Request

## Canonical Fields

- project_name: 紫微斗數
- define_page_id: 390b9e33-8429-81df-87d9-f8de6e4845b1
- define_run_id: notion--define-20260701174341
- chain_id: raw:unknown:390b9e33-156bcc5c
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

簡單使用紫微斗數，起到教學，算命的作用，卦象解說

## Idea Expansion Governance

Define Idea Expansion Governance:
- Define may expand a raw idea only as labeled interpretation, assumption, candidate, or recommended-not-confirmed direction.
- Define must not promote invented gameplay, genre, story, platform, monetization, visual direction, success metric, or target audience into Confirmed Requirements unless the Raw Idea explicitly states it.
- Every Expansion Candidate must include: source cue from Raw Idea, proposed product/game direction, why it fits, gameplay impact, visual/experience impact, risk, and decision status.
- Recommended Direction is allowed, but it must be labeled Recommended, not confirmed.
- Planning may use candidates for comparison and synthesis, but must keep the candidate provenance visible in planning documents and handoffs.
- If Raw Idea is too thin, Define should still provide candidate directions, but Planning must mark the selected direction as assumption-backed instead of confirmed.

## Confirmed Requirements（已確認需求）

- project_name: 紫微斗數
- raw_idea: 簡單使用紫微斗數，起到教學，算命的作用，卦象解說
- product_vision: 由 Raw Idea 正規化：簡單使用紫微斗數，起到教學，算命的作用，卦象解說 遊戲概念：讓一般使用者，也可以很簡單使用的紫微斗數算命軟體 必須包含：紫微斗數教學，注意事項 Define 階段可放大構想，但放大的內容必須放在候選方向、假設或建議方向，不可放入已確認需求。
- target_audience_field: 由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。
- core_value_field: 由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。 核心玩法：使用中國人所說的生辰八字，最好是用西曆來換算成農曆，來取得命盤大數據 核心物件：紫微斗數，姓名學，算命 成功條件：可以算命？
- platform_target_field: iOS app first, local iOS simulator build and QA delivery required.
- monetization_direction_field: Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。
- compatibility_target_field: iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.
- output_expectation_field: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.

## Interpretation（Define 解讀）

- Raw Idea does not strongly define visual spectacle; visual direction must stay candidate-based.
- Raw Idea does not clearly define a repeatable core action; Planning must compare candidate core mechanics.
- Raw Idea does not confirm speed or pressure; pacing must be selected as an assumption or candidate.
- No explicit puzzle/strategy cue was found; depth candidates should focus on mastery, scoring, encounters, and progression unless user approves otherwise.

## Expansion Candidates（可放大的候選方向）

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

## Recommended Direction（建議方向，但未確認）

- Recommended, not confirmed: select one primary repeated action in Planning, then combine Readable Action Survival with Progressive Mastery Challenge to avoid a static or unclear prototype.
- decision_status: Recommended, not confirmed

## Open Questions（不可腦補的問題）

- Which Expansion Candidate should be treated as the MVP direction, or should Planning compare all candidates first?
- What is the strongest intended player feeling: speed, mastery, tension, relaxation, strategy, collection, or spectacle?
- Which visual references are approved, and which are only inspirational?
- What must be excluded from MVP scope even if it would increase depth or polish?
- What is the minimum acceptable device/OS compatibility target for release, not only simulator testing?

## Planning Input Boundary

- Planning may expand candidates into design alternatives, but must keep Confirmed / Assumption / Candidate / Open Question labels.
- Planning must not rewrite Expansion Candidates as user-approved requirements.
- If Planning chooses a candidate, it must document the rationale and whether the choice is confirmed or assumption-backed.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：簡單使用紫微斗數，起到教學，算命的作用，卦象解說
遊戲概念：讓一般使用者，也可以很簡單使用的紫微斗數算命軟體

必須包含：紫微斗數教學，注意事項

Define 階段可放大構想，但放大的內容必須放在候選方向、假設或建議方向，不可放入已確認需求。

## Target Audience（目標受眾）

由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。
核心玩法：使用中國人所說的生辰八字，最好是用西曆來換算成農曆，來取得命盤大數據
核心物件：紫微斗數，姓名學，算命
成功條件：可以算命？

## Platform Target

iOS app first, local iOS simulator build and QA delivery required.

## Monetization Direction

Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。

## Compatibility Target

iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.

## Output Expectation

Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.

## Product Experience Contract

Game Design Foundation Contract:
- Reference cards: game_system_design/GAME_DEV_BLACK_BOOK_REFERENCE.md, game_system_design/GDD_STRUCTURE_REFERENCE.md, game_system_design/GAME_MECHANICS_REFERENCE.md, game_system_design/GAME_TERMINOLOGY_REFERENCE.md, and game_quality/VISUAL_ART_REFERENCE.md must be used as bounded knowledge. Do not paste full external articles into agent context.
- GDD Structure: Planning must cover Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan before Spec Review.
- User-Centric Reverse Deduction: Define and Planning must translate user profile -> psychological need -> mechanic/system -> production/QA evidence before development.
- MDA / Feeling-to-System Mapping: every core feature must map mechanic, dynamic, and aesthetic; QA must verify runtime evidence supports the intended feeling, not only object existence.
- Core Mechanics（核心機制）: Define and Planning must name the repeatable player actions that form the gameplay foundation, such as drift, jump, shoot, build, dodge, aim, collect, or upgrade. A game cannot proceed with only passive scoring or decorative motion.
- Game Loop（遊戲循環）: Planning must express the repeatable behavior pattern as a loop, for example explore -> collect -> build -> upgrade, start -> drift -> avoid -> score -> fail -> retry, or equivalent. Each loop step needs player intent, system response, feedback, and progression meaning.
- Systems and Tuning（系統與數值）: Planning/Spec Review must define the core systems and numbers that make the game challenging and fair, including economy/reward rules where relevant, damage or failure calculation, growth/progression curve, probability/spawn balance, difficulty ramp, and fairness/readability limits.
- Level Design（關卡設計）: Planning must define spatial layout and pacing rules that guide the player and create memorable play moments, including lanes/space, spawn rhythm, encounter pacing, tutorial/readability beats, safe windows, pressure peaks, and recovery moments.
- Development and QA must reject outputs where these four foundations remain generic, missing, or not testable.
- Moment-to-Moment Gameplay Contract: Planning must define the first 10 seconds of play as timestamped beats: player sees objective, player performs input, system creates pressure, enemy/hazard advances, feedback confirms action, reward or failure teaches the next attempt.
- Encounter / Enemy Pattern Contract: Planning must define at least three concrete enemy or hazard patterns with spawn condition, movement/approach behavior, warning/readability cue, counterplay, reward/penalty, and QA reproduction step. A static or non-approaching threat fails.
- Player Skill and Reward Contract: Planning must define how player skill changes outcome, including near miss, combo, boost/reward, score formula, risk/reward tradeoff, reset/break condition, HUD/VFX/SFX feedback, and mastery signal.
- Human Playtest Contract: QA must verify from simulator video that a human can tell what the goal is, what is dangerous, what changed after input, why failure happened, and why retry is meaningful.

Human Playability Contract:
- The player must understand what to do within 3 seconds of the first playable screen.
- The first run must show visible player motion, visible hazard motion, and at least one player input that changes risk/outcome.
- The game may not be delivered as static rectangles, invisible controls, or a passive score timer.
- Retry must restart directly into a fresh playable run within 0.3 seconds unless the defined product explicitly says otherwise.
- Retry must create a human-visible state transition: failure overlay removed, score/timer/run state reset, player or track motion resumes, and the after-retry screenshot/video must differ clearly from the game-over screenshot.
- Failure must explain the cause in human-readable language and preserve a clear retry action.

Visual Richness Contract:
- Planning must define a minimum polish bar before development: background layers, track materials, player silhouette, hazard shapes, reward/boost visuals, HUD frame, typography, icon style, motion polish, and VFX budget.
- Visual richness must improve speed, risk, reward, and retry motivation without hiding the player, hazards, HUD, or controls.
- Debug-looking placeholder blocks, single-color empty playfields, overlapping state layers, or unreadable labels fail the contract.

Interaction and State Contract:
- Main Menu, Running, Paused, Failure, RetryTransition, and Settings must have mutually exclusive visible UI rules.
- Menu UI cannot be hidden in the menu screenshot; gameplay controls cannot remain active over Failure unless intentionally listed as disabled background context.
- Left/right input, pause, settings, sound toggle, and retry must each produce visible feedback.
- RetryTransition must have observable feedback such as panel fade, countdown, track flash, player respawn pulse, or refreshed hazard layout; a probe boolean alone is insufficient evidence.

Audio Feedback Contract:
- Sound On must produce verifiable audio or runtime evidence for start, drift/input, boost/reward, collision/failure, and retry/settings feedback.
- QA cannot pass audio by checking the existence of a Sound On label only.

Evidence Contract:
- Build/QA must provide simulator screenshots and playthrough video that prove menu readability, start action, gameplay motion, input effect, failure reason, retry restart, after-retry visual delta, and sound feedback evidence.

## Research Knowledge Capture Contract

Research Knowledge Capture Contract:
- External research is allowed only through bounded source cards. Agents must not paste full web pages, copied article text, competitor screenshots, or unverified claims into downstream context.
- Preferred owners: ux-researcher for player/product/gameplay references; evidence-collector for source-card evidence, attribution, and license risk; technical-artist for asset feasibility; product-experience-reviewer for product-experience synthesis.
- Required knowledge base reads when research is used: research_capture/ROUTING.md, research_capture/SOURCE_CARD_SCHEMA.md, research_capture/VALIDATION_GATES.md, and research_capture/LICENSE_AND_ATTRIBUTION.md.
- Required project outputs when external research is used: docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, docs/research/Research_License_Risk_Register.md, and status/context/research_context_pack.md.
- Each source card must include source_card_id, source_title, source_url, publisher_or_author, accessed_at, source_type, license_or_terms, usage_risk, recommended_for_stage, usable_summary, design_implication, do_not_use_directly, and open_questions.
- Planning and Spec Review must cite source card ids or bounded internal knowledge-base paths for research-based claims.
- Development may directly use external assets only when a source card marks usage_risk=low and direct_asset_use_allowed=true.
- QA must fail if a product claim, asset, platform rule, or product-experience benchmark depends on external research but no source card or license risk record exists.

## Initial Research Source Cards

```yaml
source_card_id: internal-kb-game-quality-001
source_title: OpenClaw Game Quality Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/game_quality/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Use GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, QUALITY_RUBRIC.md, and VALIDATION_GATES.md as bounded quality references.
- design_implication: Planning must turn quality goals into concrete player actions, system responses, feedback events, and QA evidence.
- do_not_use_directly: Do not paste whole knowledge-base files into downstream handoffs.
- open_questions: Project-specific benchmark sources still need research capture if Raw Idea asks for external inspiration.

```yaml
source_card_id: internal-kb-research-capture-001
source_title: OpenClaw Research Capture Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/research_capture/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: raw_idea, define, planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: External research must become source cards with source URL, accessed date, license/terms, usage risk, usable summary, design implication, and do-not-use-directly notes.
- design_implication: Agents may search the web, but downstream stages consume only source cards and synthesis.
- do_not_use_directly: Do not use raw external pages or unlicensed assets as production input.
- open_questions: External references supplied by user must be converted into full source cards before direct downstream use.

```yaml
source_card_id: raw-reference-pending-001
source_title: No explicit raw reference provided
source_url: (not provided)
publisher_or_author: unknown
accessed_at: pending_research_capture
source_type: other
license_or_terms: unknown
usage_risk: medium
recommended_for_stage: define, planning
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Pending. A research owner must inspect and summarize this reference if it affects product direction.
- design_implication: Treat as inspiration only until converted into validated source card.
- do_not_use_directly: Do not copy text, images, audio, UI, or product claims from this reference before license and source review.
- open_questions: Verify source URL, author/publisher, license/terms, and applicable design implication.

## Development Request

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea. Do not invent a missing game concept as a confirmed fact; if a required product/game concept is unclear, keep it labeled as open question or candidate instead of allowing Planning to guess.
Define may expand the idea, but only as Interpretation, Expansion Candidate, Assumption, or Recommended-not-confirmed direction.
Every Expansion Candidate must include source cue, proposed direction, gameplay impact, visual/experience impact, risk, and decision status.
Planning must compare or select candidates with rationale; candidates must not become confirmed requirements without user approval or explicit downstream decision evidence.
External research rule: if Reference contains URLs, asset libraries, competitor examples, app-store guidelines, platform docs, or market examples, Define must convert them into Research Knowledge Cards instead of raw citations.
Research cards must preserve source_card_id, source_url, accessed_at, license_or_terms, usage_risk, design_implication, and do_not_use_directly. Unknown license or direct-use rights must be treated as pending/high risk until evidence-collector or ux-researcher verifies them.
Planning, Spec Review, Development, Build, and QA may use external references only through docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, and docs/research/Research_License_Risk_Register.md.
Raw idea type: app
Priority: medium

Raw idea:
簡單使用紫微斗數，起到教學，算命的作用，卦象解說

Game concept fields:
Game Concept: 讓一般使用者，也可以很簡單使用的紫微斗數算命軟體
Player Goal: (not provided)
Core Gameplay: 使用中國人所說的生辰八字，最好是用西曆來換算成農曆，來取得命盤大數據
Core Objects: 紫微斗數，姓名學，算命
Visual Direction: (not provided)
Success Criteria: 可以算命？
Must Have: 紫微斗數教學，注意事項
Must Not: (not provided)
Reference: (not provided)
Monetization Direction: (not provided)
Compatibility Target: (not provided)
QA Requirement: (not provided)
